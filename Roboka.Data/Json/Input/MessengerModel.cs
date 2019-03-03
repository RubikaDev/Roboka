using Newtonsoft.Json;

namespace Roboka.Data.Json.Input
{
    public class MessengerModel<T> where T : class
    {
        public MessengerModel()
        {
            ApiVersion = Variables.ApiVersion;
        }

        [JsonProperty("api_version")] public string ApiVersion { get; set; }
        [JsonProperty("method")] public string Method { get; set; }
        [JsonProperty("data")] public T Data { get; set; }
    }
}
