using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Roboka.Data.Enum;

namespace Roboka.Data.Model
{
    public class AuxDataModel
    {
        [JsonProperty("start_id")] public string StartId { get; set; }
        [JsonProperty("button_id")] public string ButtonId { get; set; }
        [JsonProperty("order_id")] public string OrderId { get; set; }
        [JsonProperty("order_status")] [JsonConverter(typeof(StringEnumConverter))] public OrderStatusEnum OrderStatus { get; set; }
    }
}
