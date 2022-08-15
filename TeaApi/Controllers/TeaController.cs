using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TeaApi.Controllers
{

    [ApiController]
    [Route("api/[Controller]")]
    public class TeaController : ControllerBase
    {
        [Route("GetTea")]
        [HttpGet]
        public ActionResult GetTea()
        {
            return Ok("Tea");
        }
    }
}
