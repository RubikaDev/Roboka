using Newtonsoft.Json;

namespace Roboka.Data.Json.Input
{
    public class GetChatInfoInput
    {
        [JsonProperty("chat_id")] public string ChatId { get; set; }
    }
}
