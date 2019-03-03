using Roboka.Data;
using Roboka.Data.Json.Input;
using Roboka.Data.Json.Output;
using Roboka.NetFramework.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Roboka.NetFramework.Services
{
    public class MessengerService : IMessengerService
    {
        private readonly IApiService _apiService;


        public MessengerService(IApiService apiService)
        {
            _apiService = apiService;
        }

        private async Task<TOutput> Request<TInput, TOutput>(string method, TInput model) where TOutput : class where TInput : class
        {
            try
            {
                var result = await _apiService.PostAsync<TOutput>(Variables.BotApi, new MessengerModel<TInput>
                {
                    Method = method,
                    Data = model
                }, Variables.MessengerHeader);

                return result;
            }
            catch (Exception e)
            {
                // TODO log
                return null;
            }
        }

        public async Task<SendMessageOutput> SendMessageAsync(SendMessageInput model)
        {
            return await Request<SendMessageInput, SendMessageOutput>(Methods.SendMessage, model);
        }

        public async Task<RequestUploadFileOutput> RequestUploadFileAsync(RequestUploadFileInput model)
        {
            return await Request<RequestUploadFileInput, RequestUploadFileOutput>(Methods.RequestUploadFile, model);
        }

        public async Task<SendFileOutput> SendFileAsync(SendFileInput model)
        {
            try
            {
                var headers = new Dictionary<string, string>
                {
                    {Variables.SendFileHeader.Token, Variables.Token},
                    {Variables.SendFileHeader.FileId, model.FileId},
                    {Variables.SendFileHeader.HashSendFile, model.HashSendFile}
                };

                return await _apiService.UploadBinaryAsync<SendFileOutput>(model.UploadUrl, model.FilePath, headers);
            }
            catch (Exception e)
            {
                // TODO log
                return null;
            }
        }

        public async Task<GetMessagesOutput> GetMessagesAsync(GetMessagesInput model)
        {
            return await Request<GetMessagesInput, GetMessagesOutput>(Methods.GetMessages, model);
        }

        public async Task<GetChatInfoOutput> GetChatInfoAsync(GetChatInfoInput model)
        {
            return await Request<GetChatInfoInput, GetChatInfoOutput>(Methods.GetChatInfo, model);
        }

        public async Task<UpdateBotEndpointsOutput> UpdateBotEndpointsAsync(UpdateBotEndpointsInput model)
        {
            return await Request<UpdateBotEndpointsInput, UpdateBotEndpointsOutput>(Methods.UpdateBotEndpoints, model);
        }
    }
}