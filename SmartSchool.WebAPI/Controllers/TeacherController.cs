using Microsoft.AspNetCore.Mvc;

namespace SmartSchool.WebAPI.Controllers
{

    [ApiController]
    [Route("/[controller]")]
    public class TeacherController : ControllerBase
    {
        public TeacherController() { }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Teachers: Pedro, João, Roger");
        }
    }
}
