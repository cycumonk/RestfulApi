using Microsoft.AspNetCore.Mvc;

namespace RestfulApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { project = "restful api 1.0.0" });
        }
    }
}
