using Newtonsoft.Json;

namespace Roboka.Data.Model
{
    public class ButtonAlertModel
    {
        [JsonProperty("message")] public string Message { get; set; }
    }
}
