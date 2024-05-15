using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Bakalari.NET
{
    public class Marks : ErrorInfo
    {
        [JsonProperty("Subjects")] public Subject[]? Subjects { get; set; }
        
        // TODO: Add getter
        public static async Task<Marks?> GetMarks(HttpClient httpClient)
        {
            // Bearer token is added in Login
            using var response = await httpClient.GetAsync("/api/3/marks");

            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Marks>(resultString);

            return result;
        }
    }
}