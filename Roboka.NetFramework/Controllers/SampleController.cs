using Roboka.Data.Json.Input;
using Roboka.NetFramework.Services.Interfaces;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace Roboka.NetFramework.Controllers
{
    [RoutePrefix("sample")]
    public class SampleController : ApiController
    {
        private readonly IMessengerService _messengerService;

        public SampleController(IMessengerService messengerService)
        {
            _messengerService = messengerService;
        }

        [HttpPost, Route(nameof(SendMessage))]
        public async Task<IHttpActionResult> SendMessage([FromBody] SendMessageInput input)
        {
            try
            {
                var result = await _messengerService.SendMessageAsync(input);
                return Ok(result);
            }
            catch (Exception exception)
            {
                return InternalServerError(exception);
            }
        }

        [HttpPost, Route(nameof(RequestUploadFile))]
        public async Task<IHttpActionResult> RequestUploadFile([FromBody] RequestUploadFileInput input)
        {
            try
            {
                var result = await _messengerService.RequestUploadFileAsync(input);
                return Ok(result);
            }
            catch (Exception exception)
            {
                return InternalServerError(exception);
            }
        }

        [HttpPost, Route(nameof(SendFile))]
        public async Task<IHttpActionResult> SendFile([FromBody] SendFileInput input)
        {
            try
            {
                var result = await _messengerService.SendFileAsync(input);
                return Ok(result);
            }
            catch (Exception exception)
            {
                return InternalServerError(exception);
            }
        }

        [HttpPost, Route(nameof(GetMessages))]
        public async Task<IHttpActionResult> GetMessages([FromBody] GetMessagesInput input)
        {
            try
            {
                var result = await _messengerService.GetMessagesAsync(input);
                return Ok(result);
            }
            catch (Exception exception)
            {
                return InternalServerError(exception);
            }
        }

        [HttpPost, Route(nameof(GetChatInfo))]
        public async Task<IHttpActionResult> GetChatInfo([FromBody] GetChatInfoInput input)
        {
            try
            {
                var result = await _messengerService.GetChatInfoAsync(input);
                return Ok(result);
            }
            catch (Exception exception)
            {
                return InternalServerError(exception);
            }
        }

        [HttpPost, Route(nameof(UpdateBotEndpoints))]
        public async Task<IHttpActionResult> UpdateBotEndpoints([FromBody] UpdateBotEndpointsInput input)
        {
            try
            {
                var result = await _messengerService.UpdateBotEndpointsAsync(input);
                return Ok(result);
            }
            catch (Exception exception)
            {
                return InternalServerError(exception);
            }
        }
    }
}
