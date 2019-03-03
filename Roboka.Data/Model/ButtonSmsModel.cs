using Newtonsoft.Json;

namespace Roboka.Data.Model
{
    public class ButtonSmsModel
    {
        [JsonProperty("to_number")] public string ToNumber { get; set; }
        [JsonProperty("message")] public string Message { get; set; }
    }
}
