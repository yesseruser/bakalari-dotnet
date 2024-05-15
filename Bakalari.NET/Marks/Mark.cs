using Newtonsoft.Json;

namespace Bakalari.NET
{
    public class Mark
    {
        [JsonProperty("MarkDate")] public string? MarkDate { get; set; }
        [JsonProperty("EditDate")] public string? EditDate { get; set; }
        [JsonProperty("Caption")] public string? Caption { get; set; }
        [JsonProperty("Theme")] public string? Theme { get; set; }
        [JsonProperty("MarkText")] public string? MarkText { get; set; }
        [JsonProperty("TeacherId")] public string? TeacherId { get; set; }
        [JsonProperty("Type")] public string? Type { get; set; }
        [JsonProperty("TypeNote")] public string? TypeNote { get; set; }
        [JsonProperty("Weight")] public double? Weight { get; set; }
        [JsonProperty("SubjectId")] public string? SubjectId { get; set; }
        [JsonProperty("IsNew")] public bool? IsNew { get; set; }
        [JsonProperty("IsPoints")] public bool? IsPoints { get; set; }
        [JsonProperty("CalculatedMarkText")] public string? CalculatedMarkText { get; set; }
        [JsonProperty("Id")] public string? Id { get; set; }
        [JsonProperty("PointsText")] public string? PointsText { get; set; }
        [JsonProperty("MaxPoints")] public int? MaxPoints { get; set; }
    }
}