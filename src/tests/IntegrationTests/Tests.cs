namespace Predibase.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static string DeploymentName =>
        Environment.GetEnvironmentVariable("PREDIBASE_DEPLOYMENT_NAME") is { Length: > 0 } value
            ? value
            : "my-deployment";

    private static PredibaseClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("PREDIBASE_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("PREDIBASE_API_KEY environment variable is not found.");

        var client = new PredibaseClient(apiKey);

        return client;
    }
}
