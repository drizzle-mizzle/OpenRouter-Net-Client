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
}
