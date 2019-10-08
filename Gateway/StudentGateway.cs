using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data.Common;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentEntryUI.Model;
using System.Configuration;

namespace StudentEntryUI.Gateway
{
    class StudentGateway 
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["UniversityConnectionDb"].ConnectionString;
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader myReader;
        private string query;

        public StudentGateway()
        {
            connection = new SqlConnection(connectionString);
        }
        public int SaveStudent (Student aStudent)       //method
        {
            connection.Open();
            query = "Insert Into Students (Name,RegNo,PhoneNo,Email,Department) Values ('" + aStudent.Name + "','" + aStudent.RegNo + "','" + aStudent.PhoneNo + "','" + aStudent.Email + "','" + aStudent.DepartmentId + "')";
            command = new SqlCommand(query, connection);
            var rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected ;
        }

        //method Registration Check
        public bool RegNoExist(Student aStudent)           
        {
            query = "SELECT * FROM Students WHERE RegNo = '"+aStudent.RegNo+"' AND Student_ID <> '"+aStudent.Id+"' ";
            command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            bool isExists= reader.HasRows;
            reader.Close();
            connection.Close();
            return isExists;
        }
        public int UpdateStudent (Student aStudent)         //method
        {
            
            query = "UPDATE Students SET Name='"+aStudent.Name+ "', RegNo ='"+aStudent.RegNo+"',PhoneNo='"+aStudent.PhoneNo+"',Email='"+aStudent.Email+ "',DepartmentId='" + aStudent.DepartmentId+"' WHERE Student_Id='" + aStudent.Id+"' ";
            command = new SqlCommand(query, connection);
            connection.Open();
            var rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }
        public List<Student> GetAllStudent()
        {

            connection.Open();
            command = new SqlCommand("SELECT * FROM Students", connection);
            SqlDataReader myReader = command.ExecuteReader();
            List<Student> studentsList = new List<Student>();

            while (myReader.Read())
            {
                Student students = new Student();
                students.Id = Convert.ToInt32(myReader["Student_Id"]);
                students.Name = myReader["Name"].ToString();
                students.RegNo = myReader["RegNo"].ToString();
                students.PhoneNo = myReader["PhoneNo"].ToString();
                students.Email = myReader["Email"].ToString();
                students.DepartmentId = Convert.ToInt32(myReader["DepartmentId"]);
                
                studentsList.Add(students);
            }
            myReader.Close();
            connection.Close();
            return studentsList;
        }

        public int RemoveStudent(Student aStudent)
        {
            query = "Delete FROM Students WHERE Student_Id = '" + aStudent.Id + "'";
            command = new SqlCommand(query,connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }
        

    }
}
