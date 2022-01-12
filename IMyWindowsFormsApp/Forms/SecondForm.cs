using IMyWindowsApp.Data.Models;
using IMyWindowsApp.Services;
using IMyWindowsFormsApp.Mappers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMyWindowsFormsApp.Forms
{
    public partial class SecondForm : Form
    {
        private readonly IStudentService _studentService;
        private readonly _IAppCache _appCache;

        public SecondForm(
             _IAppCache appCache,
            IStudentService studentService
            )
        {
            InitializeComponent();

            _studentService = studentService;
            _appCache = appCache;
            _appCache._ViewBag.TryGetValue("teacherId", out object teacherId);
            lblGuid.Text = teacherId?.ToString();
        }
        private void SecondForm_Load(object sender, EventArgs e)
        {
            RefreshStudents();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
                teacherId = (Guid)_appCache._ViewBag["teacherId"],
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text,
                Age = Convert.ToInt32(txtAge.Text)
            };
            _studentService.Add(student);

            RefreshStudents();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (grdStudents.SelectedRows.Count == 0)
                return;
            else
            {
                _studentService.Remove((Guid)grdStudents.SelectedRows[0].Cells[0].Value);
                RefreshStudents();
            }
        }

        private void grdStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowRow();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                Id = (Guid)grdStudents.SelectedRows[0].Cells["Id"].Value,
                teacherId = (Guid)grdStudents.SelectedRows[0].Cells["teacherId"].Value,
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text,
                Age = Convert.ToInt32(txtAge.Text)
            };
            _studentService.Update(student);
            RefreshStudents();
        }

        private void grdStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _appCache._ViewBag.Add("studentId", grdStudents.SelectedRows[0].Cells["Id"].Value);
            _appCache._ViewBag.Add("studentName", grdStudents.SelectedRows[0].Cells["FullName"].Value);
        }

        private void ShowRow()
        {
            string[] names = grdStudents.SelectedRows[0].Cells["FullName"].Value.ToString().Split(' ');
            txtLastName.Text = names.Last();
            txtFirstName.Text = names.First();
            txtAge.Text = grdStudents.SelectedRows[0].Cells["Age"].Value.ToString();
        }
        public void RefreshStudents()
        {
            grdStudents.ClearSelection();


            grdStudents.DataSource = _studentService.GetAllByTeacher((Guid)_appCache._ViewBag["teacherId"]).MapStudentsToViewModel().ToList();
            if (grdStudents.Rows.Count > 0)
            {
                grdStudents.Rows[0].Selected = true;
            }
        }

    }
}
