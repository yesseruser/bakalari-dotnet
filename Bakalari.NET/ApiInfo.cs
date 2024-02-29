using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Bakalari.NET
{
    public class ApiInfo : ErrorInfo
    {
        public string ApiVersion { get; set; }
        public string ApplicationVersion { get; set; }
        public string BaseUrl { get; set; }

        public ApiInfo(string apiVersion, string applicationVersion, string baseUrl)
        {
            ApiVersion = apiVersion;
            ApplicationVersion = applicationVersion;
            BaseUrl = baseUrl;
        }

        /// <summary>
        /// Gets info about the API from "/api/3".
        /// </summary>
        /// <param name="httpClient">The <see cref="HttpClient"/> with the school's URL.
        /// Use <see cref="HttpClientGenerator"/> to generate one.</param>
        /// <returns>An asynchronous <see cref="Task"/> with a nullable <see cref="ApiInfo"/> return.</returns>
        public static async Task<ApiInfo?> Get(HttpClient httpClient)
        {
            var response = await httpClient.GetAsync("api/3");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ApiInfo>(stringResponse);
            return result;
        }
    }
}
