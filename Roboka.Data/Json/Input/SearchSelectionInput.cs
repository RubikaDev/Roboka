using Newtonsoft.Json;

namespace Roboka.Data.Json.Input
{
    public class SearchSelectionInput
    {
        [JsonProperty("chat_id")] public string ChatId { get; set; }
        [JsonProperty("selection_id")] public string SelectionId { get; set; }
        [JsonProperty("search_text")] public string SearchText { get; set; }
        [JsonProperty("limit")] public int Limit { get; set; }
    }
}
