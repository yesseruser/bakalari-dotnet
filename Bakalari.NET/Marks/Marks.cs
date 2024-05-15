using Newtonsoft.Json;

namespace Bakalari.NET
{
    public class Marks : ErrorInfo
    {
        [JsonProperty("Subjects")] public Subject[]? Subjects { get; set; }
        
        // TODO: Add getter
    }
}