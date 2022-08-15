using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeApi.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CoffeeController : ControllerBase
    {
        [Route("GetCoffee")]
        [HttpGet]
        public ActionResult GetCoffee()
        {
            return Ok("Coffee");
        }
    }
}
