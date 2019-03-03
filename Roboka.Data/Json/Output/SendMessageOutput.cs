using Newtonsoft.Json;

namespace Roboka.Data.Json.Output
{
    public class SendMessageOutput
    {
        [JsonProperty("status")] public string Status { get; set; }
        [JsonProperty("status_det")] public string StatusDetail { get; set; }
        [JsonProperty("data")] public SendMessageDataOutput Data { get; set; }
    }

    public class SendMessageDataOutput
    {
        [JsonProperty("message_id")] public string MessageId { get; set; }
    }
}
