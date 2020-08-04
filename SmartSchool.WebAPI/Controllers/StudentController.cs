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
        private readonly IRepository repository;

        public StudentController(DataContext context, IRepository repository)
        {
            this.context = context;
            this.repository = repository;
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
            repository.Add(student);

            if (this.repository.SaveChanges())
            {
                return Ok(student);
            }

            return BadRequest();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Student newStudentData)
        {
            var student = context.Students.AsNoTracking().FirstOrDefault(s => s.Id == id);

            if (student == null) return BadRequest("Student Id is not found.");

            repository.Update(student);

            if (this.repository.SaveChanges())
            {
                return Ok(student);
            }

            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var student = context.Students.FirstOrDefault(s => s.Id == id);

            if (student == null) return BadRequest("Student Id is not found.");

            repository.Remove(student);

            if (this.repository.SaveChanges())
            {
                return Ok($"Student {id} was deleted.");
            }

            return BadRequest();

        }


    }
}
