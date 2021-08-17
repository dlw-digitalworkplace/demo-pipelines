using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Pipelines.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppSettingController : ControllerBase
    {
        private readonly ILogger<AppSettingController> _logger;
        private readonly IConfiguration _config;

        public AppSettingController(ILogger<AppSettingController> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        [HttpGet]
        public string Get(string key = null)
        {
            if(null == key)
            {
                return "Add url query parameter 'key'";
            }

            var value = _config[key];

            if(null == value)
            {
                return "App setting does not exist";
            }

            return value;
        }
    }
}
