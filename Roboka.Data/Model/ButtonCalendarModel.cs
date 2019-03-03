using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Roboka.Data.Enum;

namespace Roboka.Data.Model
{
    public class ButtonCalendarModel
    {
        [JsonProperty("default_value")] public string DefaultValue { get; set; }
        [JsonProperty("type")] [JsonConverter(typeof(StringEnumConverter))] public ButtonCalendarTypeEnum Type { get; set; }
        [JsonProperty("min_year")] public string MinYear { get; set; }
        [JsonProperty("max_year")] public string MaxYear { get; set; }
    }
}
