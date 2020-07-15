using Microsoft.AspNetCore.Mvc;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class StudentController : ControllerBase
    {

        public StudentController() { }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Students: Marta, Paulo, Johnsons");
        }
    }
}
