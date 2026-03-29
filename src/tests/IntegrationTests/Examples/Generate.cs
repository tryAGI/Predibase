/*
order: 10
title: Chat Completion
slug: chat-completion

Shows how to use the OpenAI-compatible chat completion endpoint
to run inference on a Predibase deployment.
*/

namespace Predibase.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatCompletion()
    {
        using var client = GetAuthenticatedClient();

        //// Send a chat completion request to a deployment.
        var response = await client.Inference.ChatCompletionAsync(
            deploymentName: DeploymentName,
            request: new ChatCompletionRequest
            {
                Messages =
                [
                    new ChatMessage
                    {
                        Role = "user",
                        Content = "What is LoRA fine-tuning?",
                    },
                ],
                MaxTokens = 256,
                Temperature = 0.7f,
            });

        response.Should().NotBeNull();
        response.Choices.Should().NotBeNullOrEmpty();
        response.Choices![0].Message.Should().NotBeNull();
    }
}
