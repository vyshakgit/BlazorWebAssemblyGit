using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorAppWebAssemblyTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly ILogger<DataController> _logger;

        public DataController(ILogger<DataController> logger)
        {
            _logger = logger;
        }

        [HttpGet("greeting")]
        public ActionResult<string> GetGreeting()
        {
            _logger.LogInformation("GetMessage endpoint called");
            return Ok("This is a sample message from the API controller.");
        }
    }
}
