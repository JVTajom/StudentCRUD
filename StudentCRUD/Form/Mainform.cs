using DevExpress.XtraEditors;
using StudentCRUD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentCRUD.Form
{
    public partial class Mainform : DevExpress.XtraEditors.XtraForm
    {
        private List<Student> studentList = new List<Student>();
        private List<Student> loadList = new List<Student>();
        public Mainform()
        {
            InitializeComponent();
            gcStudent.DataSource = loadList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student
            {
                FirstName = teFirstName.Text,
                MiddleName = teMiddleName.Text,
                LastName = teLastName.Text,
                DateOfBirth = deBirthDate.DateTime,
                Address = teAddress.Text
            };
            studentList.Add(newStudent);
            XtraMessageBox.Show("Successfully Added a Student");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadList.Clear();
            loadList.AddRange(studentList);
            gcStudent.RefreshDataSource();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gvStudent.FocusedRowHandle >= 0)
            {
                Student selectedStudent = (Student)gvStudent.GetRow(gvStudent.FocusedRowHandle);

                selectedStudent.FirstName = teFirstName.Text;
                selectedStudent.MiddleName = teMiddleName.Text;
                selectedStudent.LastName = teLastName.Text;
                selectedStudent.DateOfBirth = deBirthDate.DateTime;
                selectedStudent.Address = teAddress.Text;

                gcStudent.RefreshDataSource();

                XtraMessageBox.Show("Student information updated successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Please select a student to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}