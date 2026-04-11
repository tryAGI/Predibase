
#nullable enable

namespace Predibase
{
    /// <summary>
    /// Predibase is a fine-tuning and serverless inference platform for LLMs.<br/>
    /// Built on open-source LoRAX, it provides LoRA fine-tuning as a service<br/>
    /// with serverless inference for open-source language models.<br/>
    /// The API covers:<br/>
    /// - Deployments: manage private serverless LLM deployments<br/>
    /// - Repositories: organize fine-tuned adapters<br/>
    /// - Fine-tuning Jobs: create and monitor LoRA fine-tuning jobs<br/>
    /// - Datasets: upload and manage training datasets<br/>
    /// - Inference: OpenAI-compatible chat completions, completions, generate, classify<br/>
    /// Authentication uses Bearer token. Get your API token from Settings &gt; My Profile<br/>
    /// in the Predibase dashboard. You also need your Tenant ID for inference endpoints.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IPredibaseClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Predibase.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Predibase.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public AdaptersClient Adapters { get; }

        /// <summary>
        /// 
        /// </summary>
        public DatasetsClient Datasets { get; }

        /// <summary>
        /// 
        /// </summary>
        public DeploymentsClient Deployments { get; }

        /// <summary>
        /// 
        /// </summary>
        public FineTuningClient FineTuning { get; }

        /// <summary>
        /// 
        /// </summary>
        public InferenceClient Inference { get; }

        /// <summary>
        /// 
        /// </summary>
        public RepositoriesClient Repositories { get; }

    }
}