using Newtonsoft.Json;

namespace Roboka.Data.Json.Input
{
    public class GetChatMessagesInput
    {
        [JsonProperty("chat_id")] public string ChatId { get; set; }
        [JsonProperty("start_message_id")] public string StartMessageId { get; set; }
        [JsonProperty("limit")] public string Limit { get; set; }
    }
}
