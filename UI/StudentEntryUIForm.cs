using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StudentEntryUI.Gateway;
using StudentEntryUI.Manager;
using StudentEntryUI.Model;


namespace StudentEntryUI
{
    public partial class StudentEntryUiForm : Form
    {
        private StudentManager aStudentManager = new StudentManager();
        private DepartmentManager aDepartmentManager = new DepartmentManager();
        private StudentWithDepartmentManager astudentwithDeptmManager = new StudentWithDepartmentManager();
        public StudentEntryUiForm()
        {
            InitializeComponent();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(departmentComboBox.SelectedValue) == -1)
            {
                MessageBox.Show("Please select a Department");
                return;
            }
            Clear();
            Student aStudent = new Student();
            aStudent.Name = nameTextBox.Text;
            aStudent.RegNo = regNoTextBox.Text;
            aStudent.PhoneNo = phoneNoTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.DepartmentId = Convert.ToInt32(departmentComboBox.SelectedValue);

            if (saveButton.Text == @"Save")
            {
                string message = aStudentManager.SaveStudent(aStudent);
                MessageBox.Show(message);
                
                
            }
            else
            {
                aStudent.Id = Convert.ToInt32(hiddentIdLevel.Text);
                string message = aStudentManager.UpdateStudent(aStudent);
                MessageBox.Show(message);
                ListViewItem selectedItem = studentListView.SelectedItems[0];
            }
            PopulateListView();

        }
        private void Clear()
        {
            //todo
        }
        private void updatePhoneNoButton_Click(object sender, EventArgs e)
        {
            Student astudent = new Student();
            astudent.RegNo = regNoTextBox.Text;
            astudent.PhoneNo = phoneNoTextBox.Text;
            string message = aStudentManager.UpdateStudent(astudent);
            MessageBox.Show(message);
        }
        private void PopulateListView()
        {
            studentListView.Items.Clear();
            List<StudentWithDepartment> studentwithDept = astudentwithDeptmManager.GetStudentWithDepartment();
            foreach (StudentWithDepartment studentWithDepartment in studentwithDept)
            {
                ListViewItem item = new ListViewItem();
                item.Text = studentWithDepartment.StudentName;
                item.SubItems.Add(studentWithDepartment.RegNo);
                item.SubItems.Add(studentWithDepartment.PhoneNo);
                item.SubItems.Add(studentWithDepartment.Email);
                item.SubItems.Add(studentWithDepartment.DepartCode);
                //studentListView.Items.Add(item);
                item.Tag = studentWithDepartment;
                studentListView.Items.Add(item);
            }
        }
        private void StudentEntryUIForm_Load(object sender, EventArgs e)
        {
            Department defaultDepartment = new Department();
            defaultDepartment.Id = -1;
            defaultDepartment.Name = "--Select--";
            List<Department> departments = aDepartmentManager.GetAllDepartment();
            departments.Insert(0,defaultDepartment);
            departmentComboBox.DataSource = departments;
            departmentComboBox.DisplayMember = "Name";
            departmentComboBox.ValueMember = "Id";
            PopulateListView();
        }
        
        private void studentListView_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem selectedItem = studentListView.SelectedItems[0];
            StudentWithDepartment astudent = selectedItem.Tag as StudentWithDepartment;
            if (astudent != null)
            {           
                nameTextBox.Text = astudent.StudentName;
                regNoTextBox.Text = astudent.RegNo;
                phoneNoTextBox.Text = astudent.PhoneNo;
                emailTextBox.Text = astudent.Email;
                departmentComboBox.SelectedValue = astudent.DepartmentId;
                hiddentIdLevel.Text = astudent.StudentId.ToString();                
                saveButton.Text = @"Update";
                removeButton.Enabled = true;
            }
            
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            regNoTextBox.Clear();
            phoneNoTextBox.Clear();
            emailTextBox.Clear();
            //departmetTextBox.Clear();
            hiddentIdLevel.Text = String.Empty;
            departmentComboBox.SelectedValue = -1;
            saveButton.Text = @"Save";
            removeButton.Enabled = false;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            DialogResult result = MessageBox.Show(@"Do you want to delete?",@"Delete",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (result.Equals(DialogResult.OK))
            {
                string message = aStudentManager.RemoveStudent(student);
                MessageBox.Show(message);
            }
            else
            {
                //Same As old
            }
            
        }

        
    }
}
