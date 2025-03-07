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
       // List para sa student nga class
        private List<Student> studentList = new List<Student>();
        private List<Student> loadList = new List<Student>();
        public Mainform()
        {
            InitializeComponent();
            gcStudent.DataSource = loadList;
        }
        private void ClearTextBoxes() // For Clearing the textboxes after adding, updating, and deleting a student
        {
            teFirstName.Text = string.Empty;
            teMiddleName.Text = string.Empty;
            teLastName.Text = string.Empty;
            deBirthDate.Text = string.Empty;
            teCourse.Text = string.Empty;
            teYearLevel.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check if any of the textboxes are empty
            if (string.IsNullOrWhiteSpace(teFirstName.Text) ||
                string.IsNullOrWhiteSpace(teMiddleName.Text) ||
                string.IsNullOrWhiteSpace(teLastName.Text) ||
                deBirthDate.EditValue == null ||
                string.IsNullOrWhiteSpace(teCourse.Text) ||
                string.IsNullOrWhiteSpace(teYearLevel.Text))
            {
                XtraMessageBox.Show("Please fill in all fields before adding a student.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop execution if validation fails
            }

            // Proceed to add the student
            Student newStudent = new Student
            {
                FirstName = teFirstName.Text,
                MiddleName = teMiddleName.Text,
                LastName = teLastName.Text,
                DateOfBirth = deBirthDate.DateTime,
                Course = teCourse.Text,
                YearLevel = teYearLevel.Text
            };

            studentList.Add(newStudent);
            XtraMessageBox.Show("Successfully Added a Student", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearTextBoxes();
        }
        //Para pang Load
        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadList.Clear();
            loadList.AddRange(studentList);
            gcStudent.RefreshDataSource();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //if statement para if wala kay gi click mu display syag error
            if (gvStudent.FocusedRowHandle >= 0)
            {
                Student selectedStudent = (Student)gvStudent.GetRow(gvStudent.FocusedRowHandle);

                selectedStudent.FirstName = teFirstName.Text;
                selectedStudent.MiddleName = teMiddleName.Text;
                selectedStudent.LastName = teLastName.Text;
                selectedStudent.DateOfBirth = deBirthDate.DateTime;
                selectedStudent.Course = teCourse.Text;
                selectedStudent.YearLevel = teYearLevel.Text;

                gcStudent.RefreshDataSource();

                XtraMessageBox.Show("Student information updated successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Please select a student to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ClearTextBoxes();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedRowHandle = gvStudent.FocusedRowHandle;

            if (selectedRowHandle >= 0)
            {
                Student selectedStudent = (Student)gvStudent.GetRow(selectedRowHandle);

                if (selectedStudent != null)
                {
                    // Show confirmation dialog
                    DialogResult result = XtraMessageBox.Show(
                        "Are you sure you want to delete this student record?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    // Proceed with deletion only if user clicks "Yes"
                    if (result == DialogResult.Yes)
                    {
                        studentList.Remove(selectedStudent);
                        loadList.Remove(selectedStudent);
                        gcStudent.RefreshDataSource();
                        XtraMessageBox.Show("Student record deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Selected record is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("Please select a student to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearTextBoxes();
        }

        // Para if mu click ang user it will then display it sa textboxes
        private void gvStudent_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvStudent.FocusedRowHandle >= 0)
            {
                Student selectedStudent = (Student)gvStudent.GetRow(gvStudent.FocusedRowHandle);

                if (selectedStudent != null)
                {
                    teFirstName.Text = selectedStudent.FirstName;
                    teMiddleName.Text = selectedStudent.MiddleName;
                    teLastName.Text = selectedStudent.LastName;
                    deBirthDate.DateTime = selectedStudent.DateOfBirth;
                    teCourse.Text = selectedStudent.Course;
                    teYearLevel.Text = selectedStudent.YearLevel;
                }
            }
        }
    }
}