using qwen.ASPClient.QwenClient.Models.Exceptions;
using qwen.ASPClient.QwenClient.Models.Request;
using qwen.ASPClient.QwenClient.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace qwen.ASPClient.QwenClient.Client
{
    public class QwenClient : IQwenClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;
        private const string ApiUrl = "https://api.qwen.ai/generate";

        public QwenClient(HttpClient httpClient, string apiKey)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _apiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
        }

        public async Task<QwenResponse> GenerateResponseAsync(string prompt)
        {
            var requestBody = new QwenRequest { Prompt = prompt };
            var requestContent = new StringContent(JsonSerializer.Serialize(requestBody), Encoding.UTF8, "application/json");

            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _apiKey);

            var response = await _httpClient.PostAsync(ApiUrl, requestContent);
            var responseString = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new QwenException($"API Error: {response.StatusCode} - {responseString}");
            }

            return JsonSerializer.Deserialize<QwenResponse>(responseString);
        }
    }
}
