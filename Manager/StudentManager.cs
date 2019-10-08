using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentEntryUI.Gateway;
using StudentEntryUI.Model;
using System.Drawing;
namespace StudentEntryUI.Manager
{
    class StudentManager
    {
        private StudentGateway aStudentGateway = new StudentGateway();
        public string SaveStudent (Student aStudent)
        {
            if (aStudentGateway.RegNoExist(aStudent))
            {
                return "Registration number is exists";
            }               
            int rowAffected = aStudentGateway.SaveStudent(aStudent);
            if (rowAffected>0)
            {
                return "Saved Succesfully.";
            }
            return "Save Failed.";
        }
        public string UpdateStudent(Student aStudent)
        {
            if (aStudentGateway.RegNoExist(aStudent))
            {
                return "Registration number is exists";
            }
            var update = aStudentGateway.UpdateStudent(aStudent);
            if(update>0)
            {
                return "Updated Successfully.";
            }
            return "Update failed";
        }

        public List<Student> GetAllStudents()
        {
            return aStudentGateway.GetAllStudent();
        }
        public string RemoveStudent(Student student)
        {
            int remove = aStudentGateway.RemoveStudent(student);
            if (remove>0)
            {
                return "Remove Successful.";
            }
            return "Remove Failed.";
        }
        

        
    }
}
