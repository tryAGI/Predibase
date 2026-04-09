
#nullable enable

namespace Predibase
{
    public partial class FineTuningClient
    {


        private static readonly global::Predibase.EndPointSecurityRequirement s_CreateFinetuningJobSecurityRequirement0 =
            new global::Predibase.EndPointSecurityRequirement
            {
                Authorizations = new global::Predibase.EndPointAuthorizationRequirement[]
                {                    new global::Predibase.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Predibase.EndPointSecurityRequirement[] s_CreateFinetuningJobSecurityRequirements =
            new global::Predibase.EndPointSecurityRequirement[]
            {                s_CreateFinetuningJobSecurityRequirement0,
            };
        partial void PrepareCreateFinetuningJobArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Predibase.CreateFinetuningJobRequest request);
        partial void PrepareCreateFinetuningJobRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Predibase.CreateFinetuningJobRequest request);
        partial void ProcessCreateFinetuningJobResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateFinetuningJobResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Fine-tuning Job<br/>
        /// Create a new LoRA fine-tuning job. This is an asynchronous operation<br/>
        /// that starts training and returns immediately with the job details.<br/>
        /// Use the job ID to poll for status.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Predibase.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Predibase.FinetuningJob> CreateFinetuningJobAsync(

            global::Predibase.CreateFinetuningJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateFinetuningJobArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Predibase.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateFinetuningJobSecurityRequirements,
                operationName: "CreateFinetuningJobAsync");

            var __pathBuilder = new global::Predibase.PathBuilder(
                path: "/finetuning/jobs",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateFinetuningJobRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateFinetuningJobResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCreateFinetuningJobResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Predibase.FinetuningJob.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Predibase.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Predibase.FinetuningJob.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Predibase.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Create Fine-tuning Job<br/>
        /// Create a new LoRA fine-tuning job. This is an asynchronous operation<br/>
        /// that starts training and returns immediately with the job details.<br/>
        /// Use the job ID to poll for status.
        /// </summary>
        /// <param name="config">
        /// Configuration for a fine-tuning job.
        /// </param>
        /// <param name="dataset">
        /// Name of the dataset to use for fine-tuning.
        /// </param>
        /// <param name="repo">
        /// Name of the adapter repository to store the fine-tuned adapter.
        /// </param>
        /// <param name="description">
        /// Description for the fine-tuning job.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Predibase.FinetuningJob> CreateFinetuningJobAsync(
            global::Predibase.FinetuningConfig config,
            string dataset,
            string repo,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Predibase.CreateFinetuningJobRequest
            {
                Config = config,
                Dataset = dataset,
                Repo = repo,
                Description = description,
            };

            return await CreateFinetuningJobAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}