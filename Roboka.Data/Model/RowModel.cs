using System.Collections.Generic;
using Newtonsoft.Json;

namespace Roboka.Data.Model
{
    public class RowModel
    {
        [JsonProperty("buttons")] public List<ButtonModel> Buttons { get; set; }
    }
}
