using System.Collections.Generic;
using Newtonsoft.Json;

namespace Roboka.Data.Model
{
    public class BotKeypadModel
    {
        [JsonProperty("rows")] public List<RowModel> Rows { get; set; }
    }
}
