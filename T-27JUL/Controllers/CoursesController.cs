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
    public class CoursesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Course> Get()
        {
            var courses = new List<Course>
            {
                new Course { CourseId = 1, CourseName = "Introducción a la Programación" },
                new Course { CourseId = 2, CourseName = "Bases de Datos" },
                new Course { CourseId = 3, CourseName = "Diseño Web" },
                new Course { CourseId = 4, CourseName = "Cálculo Avanzado" },
                new Course { CourseId = 5, CourseName = "Inglés" },
                new Course { CourseId = 6, CourseName = "Programación Orientada a Objetos" }
            };

            return courses;
        }
    }
}
