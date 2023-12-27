using Microsoft.AspNetCore.Mvc;
using Singleton_pattrn.ClassSingleton;

namespace Singleton_pattrn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        [HttpGet("LoadData")]
        public IActionResult LoadData()
        {
          var data=  Counter.GetInstance().LoadData();
            return Ok(data);
        }

        [HttpGet("AddData")]
        public IActionResult AddData()
        {
            var data = Counter.GetInstance().AddData();
            return Ok(data);
        }
    }
}
