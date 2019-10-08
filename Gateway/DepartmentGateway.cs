using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using StudentEntryUI.Model;

namespace StudentEntryUI.Gateway
{
    class DepartmentGateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["UniversityConnectionDb"].ConnectionString;
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader myReader;
        private string query;

        public DepartmentGateway()
        {
            connection = new SqlConnection(connectionString);
        }
        public List<Department> GetDepartments()
        {
            query = "SELECT * FROM Departments";
            command = new SqlCommand(query,connection);
            connection.Open();
            List<Department> departments = new List<Department>();
            myReader = command.ExecuteReader();
            while (myReader.Read())
            {
                Department department = new Department();
                department.Id = (int) myReader["ID"];
                department.Code = myReader["Code"].ToString();
                department.Name = myReader["Name"].ToString();
                departments.Add(department);
                
            }
            myReader.Close();
            connection.Close();

            return departments;
        }


    }
}
