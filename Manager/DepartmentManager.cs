using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentEntryUI.Gateway;
using StudentEntryUI.Model;

namespace StudentEntryUI.Manager
{
    class DepartmentManager
    {
        private DepartmentGateway departmentGateway = new DepartmentGateway();
        public List<Department> GetAllDepartment()
        {
            return departmentGateway.GetDepartments();
        }
    }
}
