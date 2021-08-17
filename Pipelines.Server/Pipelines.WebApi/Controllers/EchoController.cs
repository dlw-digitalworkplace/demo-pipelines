using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Pipelines.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EchoController : ControllerBase
    {
        private readonly ILogger<EchoController> _logger;

        public EchoController(ILogger<EchoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get(string shout)
        {
            return shout;
        }
    }
}
