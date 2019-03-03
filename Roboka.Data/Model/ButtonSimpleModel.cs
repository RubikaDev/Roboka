using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Roboka.Data.Enum;

namespace Roboka.Data.Model
{
    public class ButtonSimpleModel
    {
        [JsonProperty("text")] public string Text { get; set; }
        [JsonProperty("image_url")] public string ImageUrl { get; set; }
        [JsonProperty("type")] [JsonConverter(typeof(StringEnumConverter))] public ButtonSimpleTypeEnum Type { get; set; }
    }
}
