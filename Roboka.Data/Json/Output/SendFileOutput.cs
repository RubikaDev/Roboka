using Newtonsoft.Json;

namespace Roboka.Data.Json.Output
{
    public class SendFileOutput
    {
        [JsonProperty("status")] public string Status { get; set; }
        [JsonProperty("status_det")] public string StatusDet { get; set; }
        [JsonProperty("dev_message")] public object DevMessage { get; set; }
        [JsonProperty("user_messsage")] public object UserMesssage { get; set; }
        [JsonProperty("data")] public Data Data { get; set; }
        [JsonProperty("data_enc")] public object DataEnc { get; set; }
    }

    public class Data
    {
        [JsonProperty("completed")] public bool Completed { get; set; }
    }
}
