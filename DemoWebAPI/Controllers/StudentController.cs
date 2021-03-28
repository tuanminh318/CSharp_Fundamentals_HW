using Microsoft.AspNetCore.Mvc;
using DemoWebAPI.BizLogics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using DemoWebAPI.Models;
using System.Threading.Tasks;

namespace DemoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ILogger<StudentController> _logger;
        private List<Student> _listStudents;

        public StudentController(ILogger<StudentController> logger)
        {
            _listStudents = new List<Student>
            {
                new Student{DateOfBirth= DateTime.Now, FirstName = "Thanh", LastName="Le"}
            };
        }

        [HttpGet]
        public List<Student> Get()
        {
            return _listStudents;
        }

        [HttpPost]
        public List<Student> Post(Student student)
        {
            _listStudents.Add(student);
            return _listStudents;
        }

        [HttpDelete]
        [Route("/api/student/delete/{index}")]
        public List<Student> Delete(int index)
        {
            _listStudents.RemoveAt(index);
            return _listStudents;
        }
    }
}
