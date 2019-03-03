using Newtonsoft.Json;

namespace Roboka.Data.Json.Output
{
    public class RequestUploadFileOutput
    {
        [JsonProperty("status")] public string Status { get; set; }
        [JsonProperty("status_det")] public string StatusDetail { get; set; }
        [JsonProperty("data")] public RequestUploadFileDataOutput Data { get; set; }
    }

    public class RequestUploadFileDataOutput
    {
        [JsonProperty("file_id")] public string FileId { get; set; }
        [JsonProperty("upload_url")] public string UploadUrl { get; set; }
        [JsonProperty("hash_send_file")] public string HashSendFile { get; set; }
    }
}
