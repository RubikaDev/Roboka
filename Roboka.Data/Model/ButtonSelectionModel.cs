using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Roboka.Data.Enum;

namespace Roboka.Data.Model
{
    public class ButtonSelectionModel
    {
        [JsonProperty("selection_id")] public string SelectionId { get; set; }
        [JsonProperty("search_type")] [JsonConverter(typeof(StringEnumConverter))] public ButtonSelectionSearchTypeEnum SearchType { get; set; }
        [JsonProperty("get_type")] [JsonConverter(typeof(StringEnumConverter))] public ButtonSelectionGetTypeEnum Type { get; set; }
        [JsonProperty("items")] public List<ButtonSimpleModel> Items { get; set; }
        [JsonProperty("is_multi_selection")] public bool IsMultiSelection { get; set; }
        [JsonProperty("columns_count")] public string ColumnsCount { get; set; }
    }
}
