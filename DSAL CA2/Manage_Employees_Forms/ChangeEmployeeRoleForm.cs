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
    public partial class ChangeEmployeeRoleForm : Form
    {
        private Employee _oneEmployee;
        public delegate void ChangeEmployeeDelegate(string uuid, EmployeeTreeNode reportingOfficer, RoleTreeNode role);
        public ChangeEmployeeDelegate callback;
        public ChangeEmployeeRoleForm()
        {
            InitializeComponent();
        }
        public ChangeEmployeeRoleForm(Employee employee)
        {
            InitializeComponent();
            _oneEmployee = employee;
        }

        private void ChangeEmployeeRoleForm_Load(object sender, EventArgs e)
        {
            txtUUID.Text = _oneEmployee.UUID;
            if (_oneEmployee.ReportingOfficer.ParentNode != null)
            {
                foreach (EmployeeTreeNode childNode in _oneEmployee.ReportingOfficer.ParentNode.ChildNodes)
                {
                    cboReportingOfficer.Items.Add(childNode.Employee.Name);
                }
            }
            else
            {
                cboReportingOfficer.Items.Add(_oneEmployee.ReportingOfficer.Employee.Name);
            }
            
            txtName.Text = _oneEmployee.Name;
            txtSalary.Text = _oneEmployee.Salary.ToString();
            foreach (RoleTreeNode childNode in _oneEmployee.RoleNode.ParentNode.ChildNodes)
            {
                cboRole.Items.Add(childNode.Role.Name);
            }
            
            chkDummyData.Checked = _oneEmployee.DummyData;
            chkSalary.Checked = _oneEmployee.SalaryAccountable;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string uuid = _oneEmployee.UUID;
            RoleTreeNode role = new RoleTreeNode();
            EmployeeTreeNode reportingOfficer = new EmployeeTreeNode();
            role = _oneEmployee.RoleNode.ParentNode.ChildNodes[cboRole.SelectedIndex];
            if (_oneEmployee.ReportingOfficer.ParentNode != null)
            {
                reportingOfficer = _oneEmployee.ReportingOfficer.ParentNode.ChildNodes[cboReportingOfficer.SelectedIndex];
            }
            else
            {
                reportingOfficer = _oneEmployee.ReportingOfficer;
            }     
            if (cboReportingOfficer.Text != "" && cboRole.Text != "")
            {
                callback(uuid, reportingOfficer, role);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
