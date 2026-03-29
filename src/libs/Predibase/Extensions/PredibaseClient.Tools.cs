#pragma warning disable CS3002 // Return type is not CLS-compliant
using Microsoft.Extensions.AI;

namespace Predibase;

/// <summary>
/// Extensions for using PredibaseClient as MEAI tools with any IChatClient.
/// </summary>
public static class PredibaseToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists all deployments,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Predibase client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListDeploymentsTool(this PredibaseClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Deployments.ListDeploymentsAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatDeploymentList(response);
            },
            name: "ListDeployments",
            description: "Lists all private serverless LLM deployments on Predibase. Returns deployment names, base models, statuses, and endpoints.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that gets details of a specific deployment,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Predibase client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetDeploymentTool(this PredibaseClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string deploymentName, CancellationToken cancellationToken) =>
            {
                var response = await client.Deployments.GetDeploymentAsync(
                    deploymentName: deploymentName,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatDeployment(response);
            },
            name: "GetDeployment",
            description: "Gets details of a specific Predibase deployment by name, including its status, base model, configuration, and serving endpoint.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that creates a fine-tuning job,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Predibase client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsCreateFinetuningJobTool(this PredibaseClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                string baseModel,
                string dataset,
                string repo,
                string? description,
                int? epochs,
                int? rank,
                CancellationToken cancellationToken) =>
            {
                var config = new FinetuningConfig
                {
                    BaseModel = baseModel,
                    Epochs = epochs ?? 3,
                    Rank = rank ?? 16,
                };

                var response = await client.FineTuning.CreateFinetuningJobAsync(
                    request: new CreateFinetuningJobRequest
                    {
                        Config = config,
                        Dataset = dataset,
                        Repo = repo,
                        Description = description,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatFinetuningJob(response);
            },
            name: "CreateFinetuningJob",
            description: "Creates a new LoRA fine-tuning job on Predibase. Requires a base model name, dataset name, and adapter repository name. Returns the job ID and status for polling.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that gets the status of a fine-tuning job,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Predibase client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetFinetuningJobTool(this PredibaseClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string jobId, CancellationToken cancellationToken) =>
            {
                var response = await client.FineTuning.GetFinetuningJobAsync(
                    jobId: jobId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatFinetuningJob(response);
            },
            name: "GetFinetuningJob",
            description: "Gets the status and details of a Predibase fine-tuning job by its ID. Returns the job status (pending, running, completed, failed, cancelled), dataset, base model, and adapter version.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists fine-tuning jobs,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Predibase client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListFinetuningJobsTool(this PredibaseClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.FineTuning.ListFinetuningJobsAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatFinetuningJobList(response);
            },
            name: "ListFinetuningJobs",
            description: "Lists all fine-tuning jobs on Predibase. Returns job IDs, statuses, datasets, base models, and timestamps.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists datasets,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Predibase client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListDatasetsTool(this PredibaseClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Datasets.ListDatasetsAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatDatasetList(response);
            },
            name: "ListDatasets",
            description: "Lists all uploaded datasets on Predibase. Returns dataset names, statuses, row counts, and column information.");
    }

    private static string FormatDeploymentList(DeploymentList response)
    {
        var parts = new List<string>();

        if (response.Data is { Count: > 0 })
        {
            parts.Add("Deployments:");
            foreach (var deployment in response.Data)
            {
                parts.Add(FormatDeployment(deployment));
                parts.Add("---");
            }
        }
        else
        {
            parts.Add("No deployments found.");
        }

        return string.Join("\n", parts);
    }

    private static string FormatDeployment(Deployment deployment)
    {
        var parts = new List<string>();

        if (!string.IsNullOrWhiteSpace(deployment.Name))
        {
            parts.Add($"Name: {deployment.Name}");
        }
        if (deployment.Status is { } status)
        {
            parts.Add($"Status: {status.ToValueString()}");
        }
        if (!string.IsNullOrWhiteSpace(deployment.Model))
        {
            parts.Add($"Model: {deployment.Model}");
        }
        if (!string.IsNullOrWhiteSpace(deployment.Endpoint))
        {
            parts.Add($"Endpoint: {deployment.Endpoint}");
        }
        if (deployment.Config is { } config)
        {
            if (!string.IsNullOrWhiteSpace(config.BaseModel))
            {
                parts.Add($"Base Model: {config.BaseModel}");
            }
            if (config.Quantization is { } q)
            {
                parts.Add($"Quantization: {q.ToValueString()}");
            }
            parts.Add($"Replicas: {config.MinReplicas ?? 0}-{config.MaxReplicas ?? 1}");
        }

        return string.Join("\n", parts);
    }

    private static string FormatFinetuningJob(FinetuningJob job)
    {
        var parts = new List<string>();

        if (!string.IsNullOrWhiteSpace(job.Uuid))
        {
            parts.Add($"Job ID: {job.Uuid}");
        }
        if (job.Status is { } status)
        {
            parts.Add($"Status: {status.ToValueString()}");
        }
        if (!string.IsNullOrWhiteSpace(job.Dataset))
        {
            parts.Add($"Dataset: {job.Dataset}");
        }
        if (!string.IsNullOrWhiteSpace(job.Repo))
        {
            parts.Add($"Repository: {job.Repo}");
        }
        if (job.Config is { } config)
        {
            if (!string.IsNullOrWhiteSpace(config.BaseModel))
            {
                parts.Add($"Base Model: {config.BaseModel}");
            }
            parts.Add($"Epochs: {config.Epochs ?? 3}");
            parts.Add($"Rank: {config.Rank ?? 16}");
        }
        if (job.AdapterVersion is { } version)
        {
            parts.Add($"Adapter Version: {version}");
        }
        if (!string.IsNullOrWhiteSpace(job.Description))
        {
            parts.Add($"Description: {job.Description}");
        }

        return string.Join("\n", parts);
    }

    private static string FormatFinetuningJobList(FinetuningJobList response)
    {
        var parts = new List<string>();

        if (response.Data is { Count: > 0 })
        {
            parts.Add("Fine-tuning Jobs:");
            foreach (var job in response.Data)
            {
                parts.Add(FormatFinetuningJob(job));
                parts.Add("---");
            }
        }
        else
        {
            parts.Add("No fine-tuning jobs found.");
        }

        return string.Join("\n", parts);
    }

    private static string FormatDatasetList(DatasetList response)
    {
        var parts = new List<string>();

        if (response.Data is { Count: > 0 })
        {
            parts.Add("Datasets:");
            foreach (var dataset in response.Data)
            {
                var entry = $"- {dataset.Name}";
                if (dataset.Status is { } status)
                {
                    entry += $" ({status.ToValueString()})";
                }
                if (dataset.RowCount is { } rows)
                {
                    entry += $" [{rows} rows]";
                }
                if (dataset.Columns is { Count: > 0 })
                {
                    entry += $" columns: {string.Join(", ", dataset.Columns)}";
                }
                parts.Add(entry);
            }
        }
        else
        {
            parts.Add("No datasets found.");
        }

        return string.Join("\n", parts);
    }
}
