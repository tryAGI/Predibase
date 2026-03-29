# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Predibase SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to Predibase's LLM deployment management, LoRA fine-tuning job creation and monitoring, and dataset browsing.

## Installation

```bash
dotnet add package Predibase
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsListDeploymentsTool()` | `ListDeployments` | List all private serverless LLM deployments with status and endpoints |
| `AsGetDeploymentTool()` | `GetDeployment` | Get details of a specific deployment by name |
| `AsCreateFinetuningJobTool()` | `CreateFinetuningJob` | Create a new LoRA fine-tuning job with base model, dataset, and config |
| `AsGetFinetuningJobTool()` | `GetFinetuningJob` | Get fine-tuning job status by ID |
| `AsListFinetuningJobsTool()` | `ListFinetuningJobs` | List all fine-tuning jobs with statuses and timestamps |
| `AsListDatasetsTool()` | `ListDatasets` | List all uploaded datasets with row counts and column info |

## Usage

```csharp
using Predibase;
using Microsoft.Extensions.AI;

var predibaseClient = new PredibaseClient(
    apiKey: Environment.GetEnvironmentVariable("PREDIBASE_API_KEY")!);

var options = new ChatOptions
{
    Tools =
    [
        predibaseClient.AsListDeploymentsTool(),
        predibaseClient.AsGetDeploymentTool(),
        predibaseClient.AsListFinetuningJobsTool(),
        predibaseClient.AsListDatasetsTool(),
    ],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "Show me all active deployments and their fine-tuning job statuses."),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```
