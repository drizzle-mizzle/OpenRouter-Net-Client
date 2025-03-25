using OpenRouter.Client;

namespace OpenRouter.Test;


public class Tests
{
    private static OpenRouterClient client = new();

    [SetUp]
    public void Setup()
    {
        var key = File.ReadAllText("key.txt").Trim();
        client.SetDefaultApiKey(key);
    }


    [Test]
    public async Task Models()
    {
        var models = await client.ModelsAsync();

        Assert.That(models, Is.Not.Empty);
    }


    [Test]
    public async Task Complete()
    {
        var response = await client.CompleteAsync("deepseek/deepseek-chat-v3-0324:free", [
            new()
            {
                Content = "Hello!",
                Role = "User"
            }
        ]);
    }
}
