using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CodeSnippetTool.Services
{
    public class OpenAIHelper
    {
        public static string apiKey { get; set; }

        private static readonly string apiEndpoint = "https://api.openai.com/v1/chat/completions"; // OpenAI API endpoint

        // Method to get AI analysis of the code
        public static async Task<string> GetAIAnalysisAsync(string languageName, string codeSnippetText)
        {
            using var httpClient = new HttpClient();

            // Prepare the prompt
            string prompt = $"Analyze my code for its purpose. It is written in {languageName}: {codeSnippetText}";

            // Create the request payload
            var payload = new
            {
                model = "gpt-3.5-turbo", // Model name
                messages = new[]
                {
                    new { role = "user", content = prompt }
                },                
                temperature = 1,
                max_tokens = 2048,
                top_p = 1,
                frequency_penalty = 0,
                presence_penalty = 0
            };

            // Serialize the payload to JSON
            string jsonPayload = JsonSerializer.Serialize(payload);

            // Set up the HTTP request
            using var request = new HttpRequestMessage(HttpMethod.Post, apiEndpoint)
            {
                Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json")
            };

            // Add the API key to the authorization header
            request.Headers.Add("Authorization", $"Bearer {apiKey}");

            try
            {
                // Send the request and get the response
                HttpResponseMessage response = await httpClient.SendAsync(request);

                if (!response.IsSuccessStatusCode)
                {
                    // Handle unsuccessful responses
                    string errorDetails = await response.Content.ReadAsStringAsync();
                    throw new InvalidOperationException($"API request failed with status {response.StatusCode}: {errorDetails}");
                }

                // Parse and return the response content
                string responseContent = await response.Content.ReadAsStringAsync();
                var jsonResponse = JsonDocument.Parse(responseContent);

                // Extract the text from the response
                string analysisText = jsonResponse.RootElement
                    .GetProperty("choices")[0]
                    .GetProperty("message")
                    .GetProperty("content")
                    .GetString();

                return analysisText;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to get AI analysis.", ex);
            }
        }
    }
}
