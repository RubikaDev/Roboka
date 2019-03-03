using Newtonsoft.Json;
using Roboka.Data.Model;
using System.Collections.Generic;

namespace Roboka.Data.Json.Output
{
    public class GetMessagesOutput
    {
        [JsonProperty("status")] public string Status { get; set; }
        [JsonProperty("status_det")] public string StatusDetail { get; set; }
        [JsonProperty("data")] public GetMessagesDataOutput Data { get; set; }
    }

    public class GetMessagesDataOutput
    {
        [JsonProperty("messages")] public List<MessageModel> MessageList { get; set; }
    }
}
