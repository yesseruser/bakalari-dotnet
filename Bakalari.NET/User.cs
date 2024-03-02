using Newtonsoft.Json;

namespace Bakalari.NET
{
    public class User : ErrorInfo
    {
        [JsonProperty("UserUID")] public string UserID { get; set; }
        [JsonProperty("CampaignCategoryCode")] public string CampaignCategoryCode { get; set; }
    }
}