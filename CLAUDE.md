# CLAUDE.md -- Predibase SDK

## Overview

Auto-generated C# SDK for [Predibase](https://predibase.com/) -- LoRA fine-tuning and serverless inference platform for open-source LLMs, built on open-source LoRAX.
**No single public OpenAPI spec covers both platform and inference APIs** -- `openapi.yaml` was manually created from Predibase documentation and the partial LoRAX inference spec.

## Build & Test

```bash
dotnet build Predibase.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth:

```csharp
var client = new PredibaseClient(apiKey); // PREDIBASE_API_KEY env var
```

Base URL: `https://api.app.predibase.com/v1`

## Key Files

- `src/libs/Predibase/openapi.yaml` -- **Manually maintained** OpenAPI spec (combines platform + inference APIs)
- `src/libs/Predibase/generate.sh` -- Runs autosdk on local spec with `--security-scheme Http:Header:Bearer`
- `src/libs/Predibase/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/Predibase/Extensions/PredibaseClient.Tools.cs` -- MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Spec Notes

- **No single public OpenAPI spec** -- Predibase publishes a partial LoRAX inference spec at `/api-reference/lorax_openapi.json`, but platform management APIs (deployments, repos, adapters, fine-tuning, datasets) are only documented in the Python SDK reference
- `openapi.yaml` was manually created to cover both planes
- Sub-client pattern: `client.Deployments.*`, `client.FineTuning.*`, `client.Inference.*`, `client.Repositories.*`, `client.Adapters.*`, `client.Datasets.*`
- Auth: `--security-scheme Http:Header:Bearer` generates constructor with `apiKey` parameter

## API Categories

### Platform Management
| Sub-client | Operations |
|------------|-----------|
| `client.Deployments` | List, Get, Create, Update, Delete deployments |
| `client.Repositories` | List, Get, Create adapter repositories |
| `client.Adapters` | List, Get, Delete, Cancel adapter training |
| `client.FineTuning` | List, Get, Create, Cancel fine-tuning jobs |
| `client.Datasets` | List, Get, Delete datasets |

### Inference (per deployment)
| Operation | Description |
|-----------|-------------|
| `client.Inference.ChatCompletionAsync()` | OpenAI-compatible chat completions |
| `client.Inference.CompletionAsync()` | OpenAI-compatible text completions |
| `client.Inference.GenerateAsync()` | LoRAX native generate endpoint |
| `client.Inference.ClassifyAsync()` | Batch classification |
| `client.Inference.GetDeploymentInfoAsync()` | Endpoint info (model, limits) |
| `client.Inference.GetDeploymentHealthAsync()` | Health check |

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsListDeploymentsTool()` -- List all deployments with status and model info
- `AsGetDeploymentTool()` -- Get details of a specific deployment
- `AsCreateFinetuningJobTool()` -- Create a new LoRA fine-tuning job
- `AsGetFinetuningJobTool()` -- Get fine-tuning job status by ID
- `AsListFinetuningJobsTool()` -- List all fine-tuning jobs
- `AsListDatasetsTool()` -- List all uploaded datasets

No MEAI interface (`IChatClient`, `IEmbeddingGenerator`, `ISpeechToTextClient`) is implemented -- the inference API is OpenAI-compatible, so MEAI chat support is available via `CustomProviders` pattern in `tryAGI.OpenAI`.
