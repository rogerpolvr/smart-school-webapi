using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class StudentController : ControllerBase
    {
        public List<Student> students = new List<Student>()
        {
            new Student()
            {
                Id = 1,
                Name = "Roger",
                Surname = "Oliveira",
                PhoneNumber = "12345678"
            },
            new Student()
            {
                Id = 2,
                Name = "Fernando",
                Surname = "Binkowski",
                PhoneNumber = "87654321"
            },
            new Student()
            {
                Id = 3,
                Name = "Mariely",
                Surname = "Becker",
                PhoneNumber = "12348765"
            },
        };

        public StudentController() { }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(students);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null) return BadRequest("Student id not found.");

            return Ok(student);
        }


    }
}
