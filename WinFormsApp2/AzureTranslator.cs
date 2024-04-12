using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WinFormsApp
{
    public class AzureTranslator
    {
        private readonly string subscriptionKey;
        private readonly string endpoint;
        private readonly string location;

        public AzureTranslator(string subscriptionKey, string endpoint, string location)
        {
            this.subscriptionKey = subscriptionKey;
            this.endpoint = endpoint;
            this.location = location;
        }

        public async Task<string> TranslateTextAsync(string inputText, string toLanguage)
        {
            string route = $"/translate?api-version=3.0&to={toLanguage}";
            object[] body = new object[] { new { Text = inputText } };
            var requestBody = JsonConvert.SerializeObject(body);

            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage())
            {
                // Build the request.
                request.Method = HttpMethod.Post;
                request.RequestUri = new Uri(endpoint + route);
                request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
                request.Headers.Add("Ocp-Apim-Subscription-Key", subscriptionKey);
                request.Headers.Add("Ocp-Apim-Subscription-Region", location);

                // Send the request and get response.
                HttpResponseMessage response = await client.SendAsync(request).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                string result = await response.Content.ReadAsStringAsync();

                // Extract the translation.
                TranslationResult[] deserializedOutput = JsonConvert.DeserializeObject<TranslationResult[]>(result);
                if (deserializedOutput.Length > 0 && deserializedOutput[0].Translations.Length > 0)
                {
                    return deserializedOutput[0].Translations[0].Text;
                }
                else
                {
                    return string.Empty;
                }
            }
        }
    }

    public class TranslationResult
    {
        [JsonProperty("translations")]
        public Translation[] Translations { get; set; }
    }

    public class Translation
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }
    }
}
