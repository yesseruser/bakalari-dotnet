using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Bakalari.NET
{
    public class Login : ErrorInfo
    {
        [JsonProperty("bak:ApiVersion")] public string ApiVersion { get; set; }
        [JsonProperty("bak:AppVersion")] public string AppVersion { get; set; }
        [JsonProperty("bak:UserId")] public string UserId { get; set; }
        
        [JsonProperty("access_token")] public string AccessToken { get; set; }
        [JsonProperty("refresh_token")] public string RefreshToken { get; set; }
        [JsonProperty("id_token")] public string IdToken { get; set; }
        [JsonProperty("token_type")] public string TokenType { get; set; }
        [JsonProperty("expires_in")] public int ExpiresIn { get; set; }
        [JsonProperty("scope")] public string Scope { get; set; }

        public Login(string apiVersion, string appVersion, string userId, string accessToken, string refreshToken, string idToken, string tokenType, int expiresIn, string scope)
        {
            ApiVersion = apiVersion;
            AppVersion = appVersion;
            UserId = userId;
            AccessToken = accessToken;
            RefreshToken = refreshToken;
            IdToken = idToken;
            TokenType = tokenType;
            ExpiresIn = expiresIn;
            Scope = scope;
        }

        public static void AddBearerTokenToHttpClient(HttpClient httpClient, string token)
        {
            httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);
        }
        
        public static async Task<Login?> GetByPassword(HttpClient httpClient, string username, string password)
        {
            var data = new[]
            {
                new KeyValuePair<string, string>("client_id", "ANDR"),
                new KeyValuePair<string, string>("grant_type", "password"),
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password)
            };

            var content = new FormUrlEncodedContent(data);

            using var response = await httpClient.PostAsync("/api/login", content);

            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Login>(resultString);
            
            if (result != null && !string.IsNullOrWhiteSpace(result.AccessToken))
                httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", "Your Oauth token");
            
            return result;
        }

        public static async Task<Login?> GetByRefreshToken(HttpClient httpClient, string refreshToken)
        {
            var data = new[]
            {
                new KeyValuePair<string, string>("client_id", "ANDR"),
                new KeyValuePair<string, string>("grant_type", "refresh_token"),
                new KeyValuePair<string, string>("refresh_token", refreshToken)
            };

            var content = new FormUrlEncodedContent(data);

            using var response = await httpClient.PostAsync("/api/login", content);

            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Login>(resultString);
            
            if (result != null && !string.IsNullOrWhiteSpace(result.AccessToken))
                httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", "Your Oauth token");
            
            return result;
        }
    }
}