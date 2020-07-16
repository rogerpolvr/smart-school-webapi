using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Data;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly DataContext context;

        public StudentController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(context.Students);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var student = context.Students.FirstOrDefault(s => s.Id == id);

            if (student == null) return BadRequest("Student id not found.");

            return Ok(student);
        }

        [HttpPost]
        public IActionResult Post(Student student)
        {
            if (student == null) return BadRequest("Student must be not empty.");

            context.Students.Add(student);

            context.SaveChangesAsync();

            return Ok(student);

        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Student student)
        {
            return Ok();
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Student student)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }


    }
}
