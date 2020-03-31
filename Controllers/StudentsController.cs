using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private IDbService dbService;

        public StudentsController(IDbService db)
        {
            this.dbService = db;
        }

        [HttpGet]
        public IActionResult GetStudents(string orderby="firstname")
        {

            return Ok(dbService.GetStudents());
        }
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            if (id == 1)
            {
                return Ok("Jan");
            }else if (id == 2)
            {
                return Ok("Kate");
            }

            return NotFound("Student not found");
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student )
        {
            student.indexnumber = $"s{new Random().Next(1,20000)}";

            return Ok(student);
        }
    }
}