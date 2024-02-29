using Newtonsoft.Json;

namespace Bakalari.NET
{
    public class ErrorInfo
    {
        [JsonProperty("error")] public string? ErrorType { get; set; }
        [JsonProperty("error_description")] public string? ErrorDescription { get; set; }

        public ErrorInfo(string errorType, string errorDescription)
        {
            ErrorType = errorType;
            ErrorDescription = errorDescription;
        }

        public ErrorInfo() { }
    }
}