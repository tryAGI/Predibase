/*
order: 30
title: Fine-tuning
slug: fine-tuning

Shows how to create and monitor LoRA fine-tuning jobs.
*/

namespace Predibase.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ListFinetuningJobs()
    {
        using var client = GetAuthenticatedClient();

        //// List all fine-tuning jobs.
        var response = await client.FineTuning.ListFinetuningJobsAsync();

        response.Should().NotBeNull();
        response.Data.Should().NotBeNull();
    }
}
