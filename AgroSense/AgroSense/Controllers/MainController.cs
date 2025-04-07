using Microsoft.AspNetCore.Mvc;

namespace AgroSense.Controllers
{
    [ApiController]
    [Route("api")]
    public class MainController : ControllerBase
    {
        
        [HttpGet("test")]
        public ActionResult Get()
        {
            return Ok();
        }
    }
}
