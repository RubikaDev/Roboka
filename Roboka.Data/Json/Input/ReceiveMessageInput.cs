using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Roboka.Data.Enum;
using Roboka.Data.Model;

namespace Roboka.Data.Json.Input
{
    public class ReceiveMessageInput
    {
        [JsonProperty("message")] public MessageModel Message { get; set; }
        [JsonProperty("type")] [JsonConverter(typeof(StringEnumConverter))] public MessageTypeEnum Type { get; set; }
    }
}