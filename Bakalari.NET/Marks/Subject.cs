using Newtonsoft.Json;

namespace Bakalari.NET
{
    public class Subject
    {
        [JsonProperty("Marks")] public Mark[]? Marks { get; set; }
        [JsonProperty("Subject")] public SubjectInfo? SubjectInfo { get; set; }
        [JsonProperty("AverageText")] public string? AverageText { get; set; }
        [JsonProperty("TemporaryMark")] public string? TemporaryMark { get; set; }
        [JsonProperty("SubjectNote")] public string? SubjectNote { get; set; }
        [JsonProperty("TemporaryMarkNote")] public string? TemporaryMarkNote { get; set; }
        [JsonProperty("PointsOnly")] public bool? PointsOnly { get; set; }
        [JsonProperty("MarkPredictionEnabled")] public bool? MarkPredictionEnabled { get; set; }
    }
}