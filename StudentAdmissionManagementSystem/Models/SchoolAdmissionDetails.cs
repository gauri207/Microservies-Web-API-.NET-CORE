using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdmissionManagementSystem.Models
{
    public class SchoolAdmissionDetails
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public DateTime DateOfJoining { get; set; }
    }
}
