using Newtonsoft.Json;
using Roboka.Data.Model;

namespace Roboka.Data.Json.Output
{
    public class ReceiveMessageOutput
    {
        [JsonProperty("bot_keypad")] public BotKeypadModel BotKeypad { get; set; }
        [JsonProperty("text_message")] public string TextMessage { get; set; }
    }
}
