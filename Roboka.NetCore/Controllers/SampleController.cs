using Microsoft.AspNetCore.Mvc;
using Roboka.Data.Json.Input;
using Roboka.NetCore.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace Roboka.NetCore.Controllers
{
    [Route("api")]
    [ApiController]
    [Produces("application/json")]
    public class SampleController : ControllerBase
    {
        private readonly IMessengerService _messengerService;

        public SampleController(IMessengerService messengerService)
        {
            _messengerService = messengerService;
        }

        [HttpPost, Route(nameof(SendMessage))]
        public async Task<IActionResult> SendMessage([FromBody] SendMessageInput input)
        {
            try
            {
                var result = await _messengerService.SendMessageAsync(input);
                return Ok(result);
            }
            catch (Exception exception)
            {
                return StatusCode(500, exception.ToString());
            }
        }

        [HttpPost, Route(nameof(RequestUploadFile))]
        public async Task<IActionResult> RequestUploadFile([FromBody] RequestUploadFileInput input)
        {
            try
            {
                var result = await _messengerService.RequestUploadFileAsync(input);
                return Ok(result);
            }
            catch (Exception exception)
            {
                return StatusCode(500, exception.ToString());
            }
        }

        [HttpPost, Route(nameof(SendFile))]
        public async Task<IActionResult> SendFile([FromBody] SendFileInput input)
        {
            try
            {
                var result = await _messengerService.SendFileAsync(input);
                return Ok(result);
            }
            catch (Exception exception)
            {
                return StatusCode(500, exception.ToString());
            }
        }

        [HttpPost, Route(nameof(GetMessages))]
        public async Task<IActionResult> GetMessages([FromBody] GetMessagesInput input)
        {
            try
            {
                var result = await _messengerService.GetMessagesAsync(input);
                return Ok(result);
            }
            catch (Exception exception)
            {
                return StatusCode(500, exception.ToString());
            }
        }

        [HttpPost, Route(nameof(GetChatInfo))]
        public async Task<IActionResult> GetChatInfo([FromBody] GetChatInfoInput input)
        {
            try
            {
                var result = await _messengerService.GetChatInfoAsync(input);
                return Ok(result);
            }
            catch (Exception exception)
            {
                return StatusCode(500, exception.ToString());
            }
        }

        [HttpPost, Route(nameof(UpdateBotEndpoints))]
        public async Task<IActionResult> UpdateBotEndpoints([FromBody] UpdateBotEndpointsInput input)
        {
            try
            {
                var result = await _messengerService.UpdateBotEndpointsAsync(input);
                return Ok(result);
            }
            catch (Exception exception)
            {
                return StatusCode(500, exception.ToString());
            }
        }
    }
}