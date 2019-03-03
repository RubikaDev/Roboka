using Newtonsoft.Json;
using Roboka.Data.Model;
using System;

namespace Roboka.Data.Json.Input
{
    public class SendMessageInput
    {
        public SendMessageInput()
        {
            var random = new Random();
            Random = random.Next(100000000, 1000000000);
            ReplyTimeout = Variables.ReplyTimeout;
        }
        [JsonProperty("chat_id")] public string ChatId { get; set; }
        [JsonProperty("text")] public string Text { get; set; }
        [JsonProperty("bot_keypad")] public BotKeypadModel Keypad { get; set; }
        [JsonProperty("reply_timeout")] public string ReplyTimeout { get; set; }
        [JsonProperty("file_id")] public string FileId { get; set; }
        [JsonProperty("rnd")] public int Random { get; set; }
        [JsonProperty("location")] public LocationModel Location { get; set; }
    }
}
