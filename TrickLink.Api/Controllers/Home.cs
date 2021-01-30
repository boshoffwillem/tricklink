using Microsoft.AspNetCore.Mvc;

namespace TrickLink.Api.Controllers
{
    [ApiController]
    [Route("api/home")]
    public class Home : ControllerBase
    {
        [HttpGet]
        public string Index()
        {
            IActionResult res = Ok("ghfjhgfj");
            return "Hello world.";
        }
    }
}