using OpenAI.Chat;
using System;
using System.Threading.Tasks;

namespace CodeSnippetTool.Services
{
    public class OpenAIHelper
    {
        private static readonly string apiKey = "your-api-key-here"; // Your OpenAI API key

        // Method to get AI analysis of the code
        public static async Task<string> GetAIAnalysisAsync(string languageName, string codeSnippetText)
        {
            // Create the prompt for the AI based on language and code
            string prompt = $"Analyze my code for its purpose. It is written in {languageName}: {codeSnippetText}";

            try
            {
                // Initialize the ChatClient with the model and API key
                var client = new ChatClient(model: "gpt-4", apiKey: apiKey);

                // Send the prompt to OpenAI and get the response
                var userMessage = new UserChatMessage(prompt);

                // Get the response asynchronously
                ChatCompletion completion = await client.CompleteChatAsync(new[] { userMessage });

                // Return the AI analysis text (the assistant's response)
                return completion.Content[0].Text.Trim();
            }
            catch (Exception ex)
            {
                // Log or handle any errors that occur during the API call
                throw new InvalidOperationException("Failed to get AI analysis.", ex);
            }
        }
    }
}