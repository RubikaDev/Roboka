using Microsoft.AspNetCore.Mvc;
using Roboka.Data.Enum;
using Roboka.Data.Json.Input;
using Roboka.Data.Json.Output;
using Roboka.NetCore.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace Roboka.NetCore.Controllers
{
    [Route("api")]
    [ApiController]
    [Produces("application/json")]
    public class DefaultController : ControllerBase
    {
        private readonly IBotService _botService;
        private readonly IMessengerService _messengerService;

        public DefaultController(IBotService botService, IMessengerService messengerService)
        {
            _botService = botService;
            _messengerService = messengerService;
        }

        [HttpPost, Route(nameof(ReceiveMessage))]
        public async Task<IActionResult> ReceiveMessage([FromBody] ReceiveMessageInput input)
        {
            try
            {
                var messageOut = _botService.Execute(input.Message);

                if (input.Type == MessageTypeEnum.API) return Ok(new ReceiveMessageOutput { BotKeypad = messageOut.Keypad, TextMessage = messageOut.Text });

                if (input.Type == MessageTypeEnum.Message) await _messengerService.SendMessageAsync(messageOut);

                return Ok();
            }
            catch (Exception exception)
            {
                return StatusCode(500, exception.ToString());
            }
        }
    }
}