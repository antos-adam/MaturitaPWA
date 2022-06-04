using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Maturita_AJAX_REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        [HttpGet]
        public string GetSomeData()
        {
            return "hello data?";
        }
    }
}
