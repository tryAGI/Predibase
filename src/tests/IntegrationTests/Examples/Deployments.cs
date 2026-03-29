/*
order: 20
title: Deployments
slug: deployments

Shows how to manage private serverless LLM deployments.
*/

namespace Predibase.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ListDeployments()
    {
        using var client = GetAuthenticatedClient();

        //// List all private serverless deployments.
        var response = await client.Deployments.ListDeploymentsAsync();

        response.Should().NotBeNull();
        response.Data.Should().NotBeNull();
    }

    [TestMethod]
    public async Task GetDeployment()
    {
        using var client = GetAuthenticatedClient();

        //// Get details of a specific deployment by name.
        var response = await client.Deployments.GetDeploymentAsync(
            deploymentName: DeploymentName);

        response.Should().NotBeNull();
        response.Name.Should().NotBeNullOrEmpty();
    }
}
