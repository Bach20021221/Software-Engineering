// Copyright © 2020 Andrew Vardeman.  Published under the MIT license.
// See license.txt in the AzureMultiTranslator distribution or repository for the
// full text of the license.

using AzureMultiTranslator.Contracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AzureMultiTranslator
{
    public class Translator
    {

        private Settings _settings;

        public Translator(Settings settings)
        {
            _settings = settings;
        }


        public static async Task DetectLanguageAsync()
        {
            string subscriptionKey = "<client-secret>"; // Thay thế bằng client-secret của bạn
            string endpoint = "https://api.cognitive.microsofttranslator.com/detect?api-version=3.0";

            // Chuỗi JSON để gửi trong yêu cầu
            string jsonBody = "[{'Text':'What language is this text written in?'}]";

            using (HttpClient client = new HttpClient())
            {
                // Thiết lập các header cho yêu cầu
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", subscriptionKey);
                client.DefaultRequestHeaders.Add("Content-Type", "application/json");

                // Tạo nội dung của yêu cầu từ chuỗi JSON
                HttpContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                try
                {
                    // Thực hiện yêu cầu POST đến API Translator
                    HttpResponseMessage response = await client.PostAsync(endpoint, content);

                    // Đọc nội dung của phản hồi
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // In ra kết quả phản hồi
                    Console.WriteLine("Response:");
                    Console.WriteLine(responseBody);
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("Error:");
                    Console.WriteLine(e.Message);
                }
            }
        }
        public async Task<List<string>> Translate(string from, string[] to, string inputText, bool html)
        {
            // Xóa các ký tự không mong muốn trong inputText
            string cleanedInputText = inputText.Trim();

            object[] body = new object[] { new { Text = cleanedInputText } };
            var requestBody = JsonConvert.SerializeObject(body);

            string textType = html ? "html" : "plain";
            string route = $"/translate?api-version=3.0&from={from}&to={string.Join("&to=", to)}&textType={textType}";

            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage())
            {
                request.Method = HttpMethod.Post;
                request.RequestUri = new Uri(_settings.Endpoint + route);
                request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
                request.Headers.Add("Ocp-Apim-Subscription-Key", "04c41096275e44ac8bb0194073bbc89b");
                request.Headers.Add("Ocp-Apim-Subscription-Region", "southeastasia");
                HttpResponseMessage response = await client.SendAsync(request).ConfigureAwait(false);

                string result = await response.Content.ReadAsStringAsync();
                List<string> translations = new List<string>();
                try
                {
                    TranslationResult[] deserializedOutput = JsonConvert.DeserializeObject<TranslationResult[]>(result);
                    foreach (TranslationResult o in deserializedOutput)
                    {
                        foreach (Translation t in o.Translations)
                        {
                            translations.Add(t.Text);
                        }
                    }

                    // Nếu kết quả dịch không thay đổi so với inputText, thông báo lỗi
                    if (translations.Count == 0 || translations.All(t => t.Equals(cleanedInputText, StringComparison.InvariantCultureIgnoreCase)))
                    {
                
                        throw new InvalidTranslationException("Không thể dịch đoạn văn truyền vào!!!!!!!");
                    }
                }
                catch (JsonException)
                {
                    try
                    {
                        ErrorWrapper wrapper = JsonConvert.DeserializeObject<ErrorWrapper>(result);
                        throw new AzureException(wrapper.Error.Code, wrapper.Error.Message);
                    }
                    catch (JsonException)
                    {
                        throw new UnrecognizedResponseException(result);
                    }
                }

                return translations;
            }
        }

        // Custom Exception class để thông báo lỗi dịch không thành công
        public class InvalidTranslationException : Exception
        {
            public InvalidTranslationException() { }

            public InvalidTranslationException(string message) : base(message) { }

            public InvalidTranslationException(string message, Exception inner) : base(message, inner) { }
        }
    

    }
}
