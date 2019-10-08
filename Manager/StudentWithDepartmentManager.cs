using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentEntryUI.Gateway;
using StudentEntryUI.Model;

namespace StudentEntryUI.Manager
{
    class StudentWithDepartmentManager
    {
        private StudentWithDepartmentGateway aStudentWithDeptGateway= new StudentWithDepartmentGateway();

        public List<StudentWithDepartment> GetStudentWithDepartment()
        {
            return aStudentWithDeptGateway.GetStudentWithDepartment();
        }

    }
}
