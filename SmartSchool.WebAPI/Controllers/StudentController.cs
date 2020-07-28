using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

            if (student == null) return BadRequest("Student Id not found.");

            return Ok(student);
        }

        [HttpPost]
        public IActionResult Post(Student student)
        {
            if (student == null) return BadRequest("Student shouldn't be empty.");

            context.Students.Add(student);

            context.SaveChangesAsync();

            return Ok(student);

        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Student newStudentData)
        {
            var student = context.Students.AsNoTracking().FirstOrDefault(s => s.Id == id);

            if (student == null) return BadRequest("Student Id is not found.");

            context.Update(newStudentData);

            context.SaveChangesAsync();

            return Ok(newStudentData);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var student = context.Students.FirstOrDefault(s => s.Id == id);

            if (student == null) return BadRequest("Student Id is not found.");

            context.Remove(student);

            context.SaveChangesAsync();

            return Ok($"Theacher {id} was deleted.");
        }


    }
}
