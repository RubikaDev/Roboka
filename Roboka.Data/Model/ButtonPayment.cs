using Newtonsoft.Json;

namespace Roboka.Data.Model
{
    public class ButtonPayment
    {
        [JsonProperty("button_payment_token")] public string ButtonPaymentToken { get; set; }
    }
}
