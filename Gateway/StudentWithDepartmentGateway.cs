using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentEntryUI.Model;

namespace StudentEntryUI.Gateway
{
    class StudentWithDepartmentGateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["UniversityConnectionDb"].ConnectionString;
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader myReader;
        private string query;

        public StudentWithDepartmentGateway()
        {
            connection = new SqlConnection(connectionString);
        }

        public List<StudentWithDepartment> GetStudentWithDepartment()
        {
            connection.Open();
            command = new SqlCommand("SELECT * FROM StudentWithDept", connection);
            SqlDataReader myReader = command.ExecuteReader();
            List<StudentWithDepartment> studentsList = new List<StudentWithDepartment>();

            while (myReader.Read())
            {
                StudentWithDepartment studentWithDept = new StudentWithDepartment();
                studentWithDept.StudentId = Convert.ToInt32(myReader["Student_Id"]);
                studentWithDept.StudentName = myReader["StudentName"].ToString();
                studentWithDept.RegNo = myReader["RegNo"].ToString();
                studentWithDept.PhoneNo = myReader["PhoneNo"].ToString();
                studentWithDept.Email = myReader["Email"].ToString();
                studentWithDept.DepartmentId = Convert.ToInt32(myReader["DeptId"]);
                studentWithDept.DepartCode = myReader["Code"].ToString();
                studentWithDept.DepartmentName = myReader["DeptName"].ToString();
                studentsList.Add(studentWithDept);
            }
            myReader.Close();
            connection.Close();
            return studentsList;
        }

        
    }
}
