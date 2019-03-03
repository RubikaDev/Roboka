using Newtonsoft.Json;
using Roboka.Data.Enum;

namespace Roboka.Data.Model
{
    public class FileInlineModel
    {
        [JsonProperty("file_url")] public string FileUrl { get; set; }
        [JsonProperty("file_name")] public string FileName { get; set; }
        [JsonProperty("type")] public GetFileTypeEnum Type { get; set; }
        [JsonProperty("size")] public string Size { get; set; }
        [JsonProperty("width")] public string Width { get; set; }
        [JsonProperty("height")] public string Height { get; set; }
        [JsonProperty("duration")] public string Duration { get; set; }
    }
}