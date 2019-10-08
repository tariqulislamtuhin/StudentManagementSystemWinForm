using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEntryUI.Model
{
    class StudentWithDepartment
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string RegNo { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public int DepartmentId { get; set; }
        public string DepartCode { get; set; }
        public string DepartmentName { get; set; }

    }
}
