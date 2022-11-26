using Microsoft.AspNetCore.Mvc;
using StudentAdmissionManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAdmissionManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAdmissionController : ControllerBase
    {
        // GET: api/<StudentAdmissionController>
        [HttpGet]
        public IEnumerable<SchoolAdmissionDetails> Get()
        {
            SchoolAdmissionDetails list1 = new SchoolAdmissionDetails()
            {
                StudentId = 101,
                Name = "Radha",
                Class = "CSE",
                DateOfJoining = DateTime.Now
            };
            SchoolAdmissionDetails list2 = new SchoolAdmissionDetails()
            {
                StudentId = 102,
                Name = "Gauri",
                Class = "CSE",
                DateOfJoining = DateTime.Now
            };
            List<SchoolAdmissionDetails> list = new List<SchoolAdmissionDetails>();
            list.Add(list1);
            list.Add(list2);
            return list;
        }

        // GET api/<StudentAdmissionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentAdmissionController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentAdmissionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentAdmissionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
