/*
order: 40
title: MEAI Tools
slug: meai-tools

Shows how to use Predibase AIFunction tools with any IChatClient.
*/

namespace Predibase.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void AsListDeploymentsTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool to list all deployments, for use with any IChatClient.
        var tool = client.AsListDeploymentsTool();
        tool.Name.Should().Be("ListDeployments");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsGetDeploymentTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool to get deployment details by name.
        var tool = client.AsGetDeploymentTool();
        tool.Name.Should().Be("GetDeployment");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsCreateFinetuningJobTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool to start a new LoRA fine-tuning job.
        var tool = client.AsCreateFinetuningJobTool();
        tool.Name.Should().Be("CreateFinetuningJob");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsGetFinetuningJobTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool to check the status of a fine-tuning job.
        var tool = client.AsGetFinetuningJobTool();
        tool.Name.Should().Be("GetFinetuningJob");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsListFinetuningJobsTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool to list all fine-tuning jobs.
        var tool = client.AsListFinetuningJobsTool();
        tool.Name.Should().Be("ListFinetuningJobs");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsListDatasetsTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool to list all uploaded datasets.
        var tool = client.AsListDatasetsTool();
        tool.Name.Should().Be("ListDatasets");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void CombineAllTools()
    {
        using var client = GetAuthenticatedClient();

        //// Combine all tools for full deployment and fine-tuning management.
        var tools = new[]
        {
            client.AsListDeploymentsTool(),
            client.AsGetDeploymentTool(),
            client.AsCreateFinetuningJobTool(),
            client.AsGetFinetuningJobTool(),
            client.AsListFinetuningJobsTool(),
            client.AsListDatasetsTool(),
        };

        tools.Should().HaveCount(6);
        tools.Select(t => t.Name).Should().OnlyHaveUniqueItems();
    }
}
