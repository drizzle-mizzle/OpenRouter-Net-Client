using OpenRouter.Client.Models;
using UniversalOpenAi.Client;
using UniversalOpenAi.Client.Models;

namespace OpenRouter.Client
{
    public class OpenRouterClient
    {
        private readonly UniversalOpenAiClient CLIENT;

        public OpenRouterClient()
        {
            CLIENT = new UniversalOpenAiClient();
            CLIENT.SetDefaultBaseUrl("https://openrouter.ai/api/v1");
        }


        public void SetDefaultApiKey(string? apiKey)
        {
            CLIENT.SetDefaultApiKey(apiKey);
        }


        public void SetDefaultRankingHeaders(string? httpReferer, string? xTitle)
        {
            var headers = new Dictionary<string, string>();

            if (!string.IsNullOrWhiteSpace(httpReferer))
            {
                headers.Add("HTTP-Referer", httpReferer);
            }

            if (!string.IsNullOrWhiteSpace(xTitle))
            {
                headers.Add("X-Title", xTitle);
            }

            CLIENT.SetDefaultHeaders(headers);
        }


        /// <summary>
        /// POST https://openrouter.ai/api/v1/chat/completions
        /// </summary>
        public Task<CompletionsResponse> CompleteAsync(string model, ChatMessage[] messages, GenerationSettings? generationSettings = null)
            => CLIENT.CompleteAsync(model, messages, generationSettings);

        public Task<CompletionsResponse> CompleteAsync(string apiKey, string model, ChatMessage[] messages, GenerationSettings? generationSettings = null)
            => CLIENT.CompleteAsync(apiKey, model, messages, generationSettings);


        public Task<OpenRouterModel[]> ModelsAsync()
            => CLIENT.ModelsAsync<OpenRouterModel>();

        public Task<OpenRouterModel[]> ModelsAsync(string apiKey)
            => CLIENT.ModelsAsync<OpenRouterModel>(apiKey);

    }
}
