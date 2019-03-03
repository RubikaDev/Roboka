using Newtonsoft.Json;

namespace Roboka.Data.Model
{
    public class ButtonCallModel
    {
        [JsonProperty("phone_number")] public string PhoneNumber { get; set; }
    }
}
