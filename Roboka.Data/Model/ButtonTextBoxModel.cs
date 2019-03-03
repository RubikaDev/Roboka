using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Roboka.Data.Enum;

namespace Roboka.Data.Model
{
    public class ButtonTextBoxModel
    {
        [JsonProperty("type_line")] [JsonConverter(typeof(StringEnumConverter))] public ButtenTextBoxLineEnum TypeLine { get; set; }
        [JsonProperty("type_keypad")] [JsonConverter(typeof(StringEnumConverter))] public ButtenTextBoxKeypadEnum TypeKeypad { get; set; }
    }
}
