using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAttendanceManagement.Models
{
    public class StudentAttendanceDetails
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public double AttendancePercentage { get; set; }
    }
}
