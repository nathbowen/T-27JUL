using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using T_27JUL.Model;

namespace T_27JUL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            var students = new List<Student>
            {
                new Student { StudentId = 1, Name = "Nathalie", LastName = "Bowen" },
                new Student { StudentId = 2, Name = "Steven", LastName = "Delgado" },
                new Student { StudentId = 3, Name = "Cristhian", LastName = "Pin" },
                new Student { StudentId = 4, Name = "Gabriel", LastName = "Medranda" },
                new Student { StudentId = 5, Name = "Mario", LastName = "Herrera" }
            };

            return students;
        }
    }
}