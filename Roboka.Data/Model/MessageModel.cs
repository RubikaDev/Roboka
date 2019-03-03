using Newtonsoft.Json;

namespace Roboka.Data.Model
{
    public class MessageModel
    {
        [JsonProperty("message_id")] public string MessageId { get; set; }
        [JsonProperty("chat_id")] public string ChatId { get; set; }
        [JsonProperty("text")] public string Text { get; set; }
        [JsonProperty("file_inline")] public FileInlineModel FileInline { get; set; }
        [JsonProperty("reply_to_message_id")] public string ReplyToMessageId { get; set; }
        [JsonProperty("time")] public string Time { get; set; }
        [JsonProperty("location")] public LocationModel Location { get; set; }
        [JsonProperty("aux_data")] public AuxDataModel AuxData { get; set; }

    }
}