using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.WebAPI.Data;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class TeacherController : ControllerBase
    {
        private readonly DataContext context;
        public TeacherController(DataContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(context.Teachers);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var teacher = context.Teachers.FirstOrDefault(t => t.Id == id);

            if (teacher == null) return BadRequest("Teacher Id is not found.");

            return Ok(teacher);
        }

        [HttpPost]
        public IActionResult Post(Teacher teacher)
        {
            if (teacher == null) return BadRequest("Teacher shouldn't be empty.");

            context.Add(teacher);

            context.SaveChangesAsync();

            return Ok(teacher);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Teacher newTeacherData)
        {
            var teacher = context.Teachers.AsNoTracking().FirstOrDefault(t => t.Id == id);

            if (teacher == null) return BadRequest("Teacher Id is not found.");

            context.Update(newTeacherData);

            context.SaveChangesAsync();

            return Ok(newTeacherData);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var teacher = context.Teachers.FirstOrDefault(t => t.Id == id);

            if (teacher == null) return BadRequest("Teacher Id is not found.");

            context.Remove(teacher);

            context.SaveChangesAsync();

            return Ok($"Theacher {id} was deleted.");
        }
    }
}
