using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Bakalari.NET
{
    public class ApiInfo
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

        public static async Task<ApiInfo?> Get(HttpClient httpClient)
        {
            var response = await httpClient.GetAsync("api/3");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ApiInfo>(stringResponse);
            return result;
        }
    }
}
