using Microsoft.AspNetCore.Mvc;
using MonitorEnergia.WebApi.Models;


namespace MonitorEnergia.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PulsoController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateItem([FromBody] PulsoInput item)
        {
            if (item == null)
            {
                return BadRequest("Invalid data");
            }

            // Your logic to save the item or perform other operations

            // For simplicity, just return the created item
            return Ok();
        }
    }
}
