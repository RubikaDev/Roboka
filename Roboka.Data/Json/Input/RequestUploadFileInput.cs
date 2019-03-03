using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Roboka.Data.Enum;

namespace Roboka.Data.Json.Input
{
    public class RequestUploadFileInput
    {
        [JsonProperty("type")] [JsonConverter(typeof(StringEnumConverter))] public SendFileTypeEnum Type { get; set; }
        [JsonProperty("file_name")] public string FileName { get; set; }
    }
}
