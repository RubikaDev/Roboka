using Newtonsoft.Json;

namespace Roboka.Data.Json.Input
{
    public class GetMessagesInput
    {
        [JsonProperty("start_message_id")] public string StartMessageId { get; set; }
        [JsonProperty("limit")] public string Limit { get; set; }
    }
}
