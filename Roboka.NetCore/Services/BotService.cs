using Roboka.Data;
using Roboka.Data.Json.Input;
using Roboka.Data.Model;
using Roboka.NetCore.Services.Interfaces;

namespace Roboka.NetCore.Services
{
    public class BotService : IBotService
    {
        public SendMessageInput Execute(MessageModel messageIn)
        {
            var messageOut = new SendMessageInput
            {
                ChatId = messageIn.ChatId,
                Keypad = Buttons.GetKeypad(messageIn.AuxData?.ButtonId),
                Text = Messages.GetMessage(messageIn.AuxData?.ButtonId)
            };

            return messageOut;
        }
    }
}