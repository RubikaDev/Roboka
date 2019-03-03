using Roboka.Data.Enum;
using Roboka.Data.Json.Input;
using Roboka.Data.Json.Output;
using Roboka.NetFramework.Services.Interfaces;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace Roboka.NetFramework.Controllers
{
    [RoutePrefix("api")]
    public class DefaultController : ApiController
    {
        private readonly IBotService _botService;
        private readonly IMessengerService _messengerService;

        public DefaultController(IBotService botService, IMessengerService messengerService)
        {
            _botService = botService;
            _messengerService = messengerService;
        }
        
        [HttpPost, Route(nameof(ReceiveMessage))]
        public async Task<IHttpActionResult> ReceiveMessage([FromBody] ReceiveMessageInput input)
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
                return InternalServerError(exception);
            }
        }
    }
}
