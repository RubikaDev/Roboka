using Roboka.Data.Enum;
using System.Collections.Generic;

namespace Roboka.Data
{
    public static class Variables
    {
        public static string ReplyTimeout => "5";
        public static string Token => "TOKEN";
        public static string BotApi => "https://botapi.rubika.ir";
        public static MessageTypeEnum ReplyType => MessageTypeEnum.Message;
        public static string ApiVersion => "2";

        public static Dictionary<string, string> MessengerHeader = new Dictionary<string, string> { { "token", Token } };
        public static class SendFileHeader
        {
            public static string Token => "token";
            public static string FileId => "file-id";
            public static string HashSendFile => "hash-send-file";
        }

    }

    
}
