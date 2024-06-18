using Microsoft.AspNetCore.Mvc;

namespace RestfulApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class DataController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] DataInputModel data)
        {
            var response = new { message = $"You submitted: {data.InputData}" };
            return Ok(response);
        }
    }

    public class DataInputModel
    {
        public string InputData { get; set; }
    }
}
