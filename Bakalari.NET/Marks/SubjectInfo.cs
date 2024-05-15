using Newtonsoft.Json;

namespace Bakalari.NET
{
    public class SubjectInfo
    {
        [JsonProperty("Id")] public string? Id { get; set; }
        [JsonProperty("Abbrev")] public string? Abbreviation { get; set; }
        [JsonProperty("Name")] public string? Name { get; set; }
    }
}