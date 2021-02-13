using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ODataLearning.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ODataLearning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return new List<Student>()
            {
                new Student
                {
                    Id= Guid.NewGuid(),
                    Name= "Dilip kumar ",
                    ClassStandard=1,
                    Score=100,

                },
                new Student
                {
                    Id=Guid.NewGuid(),
                    Name="Ashok kumar ",
                    ClassStandard=4,
                    Score=150
                }
                
            };
        }

   
    }
}
