using Newtonsoft.Json;

namespace Roboka.Data.Json.Input
{
    public class UpdateBotEndpointsInput
    {
        [JsonProperty("url")] public string Url { get; set; }
    }
}
