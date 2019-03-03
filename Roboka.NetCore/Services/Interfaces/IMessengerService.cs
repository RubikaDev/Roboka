using Roboka.Data.Json.Input;
using Roboka.Data.Json.Output;
using System.Threading.Tasks;

namespace Roboka.NetCore.Services.Interfaces
{
    public interface IMessengerService
    {
        Task<SendMessageOutput> SendMessageAsync(SendMessageInput model);
        Task<RequestUploadFileOutput> RequestUploadFileAsync(RequestUploadFileInput model);
        Task<SendFileOutput> SendFileAsync(SendFileInput model);
        Task<GetMessagesOutput> GetMessagesAsync(GetMessagesInput model);
        Task<GetChatInfoOutput> GetChatInfoAsync(GetChatInfoInput model);
        Task<UpdateBotEndpointsOutput> UpdateBotEndpointsAsync(UpdateBotEndpointsInput model);
    }
}
