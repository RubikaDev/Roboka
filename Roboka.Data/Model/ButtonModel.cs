using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Roboka.Data.Enum;

namespace Roboka.Data.Model
{
    public class ButtonModel
    {
        public ButtonModel()
        {
            ReplyType = Variables.ReplyType;
        }

        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("type")] [JsonConverter(typeof(StringEnumConverter))] public ButtonTypeEnum Type { get; set; }
        [JsonProperty("button_view")] public ButtonSimpleModel ButtonView { get; set; }
        [JsonProperty("button_selection")] public ButtonSelectionModel ButtonSelection { get; set; }
        [JsonProperty("button_calendar")] public ButtonCalendarModel ButtonCalendar { get; set; }
        [JsonProperty("button_number_picker")] public ButtonNumberPickerModel ButtonNumberPicker { get; set; }
        [JsonProperty("button_textbox")] public ButtonTextBoxModel ButtonTextBox { get; set; }
        [JsonProperty("button_call")] public ButtonCallModel ButtonCall { get; set; }
        [JsonProperty("button_sms")] public ButtonSmsModel ButtonSms { get; set; }
        [JsonProperty("button_string_picker")] public ButtonStringPickerModel ButtonStringPicker { get; set; }
        [JsonProperty("button_payment")] public ButtonPayment ButtonPayment { get; set; }
        [JsonProperty("button_alert")] public ButtonAlertModel ButtonAlert { get; set; }
        [JsonProperty("button_location")] public ButtonLocationModel ButtonLocation { get; set; }
        [JsonProperty("reply_type")] [JsonConverter(typeof(StringEnumConverter))] public MessageTypeEnum ReplyType { get; set; }
    }
}
