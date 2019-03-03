using Newtonsoft.Json;

namespace Roboka.Data.Json.Output
{
    public class GetChatInfoOutput
    {
        [JsonProperty("status")] public string Status { get; set; }
        [JsonProperty("status_det")] public string StatusDetail { get; set; }
        [JsonProperty("data")] public GetChatInfoDataOutput Data { get; set; }
    }

    public class GetChatInfoDataOutput
    {
        [JsonProperty("first_name")] public string FirstName { get; set; }
        [JsonProperty("last_name")] public string LastName { get; set; }
        [JsonProperty("username")] public string UserName { get; set; }
        [JsonProperty("last_message_id")] public string LastMessageId { get; set; }
    }
}
