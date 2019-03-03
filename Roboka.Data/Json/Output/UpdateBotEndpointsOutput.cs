using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Roboka.Data.Enum;

namespace Roboka.Data.Json.Output
{
    public class UpdateBotEndpointsOutput
    {
        [JsonProperty("status")] public string Status { get; set; }
        [JsonProperty("status_det")] public string StatusDetail { get; set; }
        [JsonProperty("data")] public UpdateBotEndpointsDataOutput Data { get; set; }
    }

    public class UpdateBotEndpointsDataOutput
    {
        [JsonProperty("status")] [JsonConverter(typeof(StringEnumConverter))] public UpdateEndpointStatusEnum Status { get; set; }
    }
}
