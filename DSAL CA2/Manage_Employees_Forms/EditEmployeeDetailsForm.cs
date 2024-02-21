using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DSAL_CA2.Classes;

namespace DSAL_CA2.Manage_Employees
{
    public partial class EditEmployeeDetailsForm : Form
    {
        private Employee _oneEmployee;
        public delegate void EditEmployeeDetailsDelegate(string uuid, string name, double salary, bool dummyData);
        public EditEmployeeDetailsDelegate callback;
        public EditEmployeeDetailsForm()
        {
            InitializeComponent();
        }
        public EditEmployeeDetailsForm(Employee employee)
        {
            InitializeComponent();
            this._oneEmployee = employee;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string uuid = txtUUID.Text.Trim();
            string name = txtName.Text.Trim();
            double salary = Convert.ToDouble(txtSalary.Text.Trim());
            bool dummyData = chkDummyData.Checked;
            if (name != "")
            {
                callback(uuid, name, salary, dummyData);
                this.DialogResult = DialogResult.OK;

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void EditEmployeeDetailsForm_Load(object sender, EventArgs e)
        {
            txtUUID.Text = _oneEmployee.UUID;
            txtReportingOfficer.Text = _oneEmployee.ReportingOfficer.Employee.Name;
            txtName.Text = _oneEmployee.Name;
            txtSalary.Text = _oneEmployee.Salary.ToString();
            txtRole.Text = _oneEmployee.RoleNode.Role.Name;
            chkDummyData.Checked = _oneEmployee.DummyData;
            chkSalary.Checked = _oneEmployee.SalaryAccountable;
        }
    }
}
