using Roboka.Data.Json.Input;
using Roboka.Data.Model;

namespace Roboka.NetFramework.Services.Interfaces
{
    public interface IBotService
    {
        SendMessageInput Execute(MessageModel messageIn);
    }
}
