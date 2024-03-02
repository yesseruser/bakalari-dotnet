using Newtonsoft.Json;

namespace Bakalari.NET
{
    public class Class
    {
        [JsonProperty("Id")] public string Id { get; set; }
        [JsonProperty("Abbrev")] public string Abbreviation { get; set; }
        [JsonProperty("Name")] public string Name { get; set; }

        public Class(string id, string abbreviation, string name)
        {
            Id = id;
            Abbreviation = abbreviation;
            Name = name;
        }
    }
}