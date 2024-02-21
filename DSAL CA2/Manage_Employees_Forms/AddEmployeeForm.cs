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
    public partial class AddEmployeeForm : Form
    {
        EmployeeTreeNode _parentNode;
        EmployeeTreeNode _childNode;
        public AddEmployeeForm()
        {
            InitializeComponent();
        }
        public AddEmployeeForm(EmployeeTreeNode node)
        {
            InitializeComponent();
            this._parentNode = node;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee temp = new Employee(txtName.Text);
            temp.ReportingOfficer = _parentNode;
            try
            {
                temp.Salary = Double.Parse(txtSalary.Text);
            } 
            catch (Exception ex)
            {
                string message = "Invalid Salary Format. Please enter only numbers.";
                string caption = "Invalid Salary";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                return;
            }
            
            if (temp.Salary > temp.ReportingOfficer.Employee.Salary)
            {
                string message = "Salary must be less than that of Reporting Officer.";
                string caption = "Invalid Salary";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                return;
            }
            RoleTreeNode role = _parentNode.Employee.RoleNode.ChildNodes[cboRole.SelectedIndex];
            if (chkDummyData.Checked)
            {
                temp.DummyData = true;
            }
            _childNode = new EmployeeTreeNode(temp, role);
            _parentNode.AddChildEmployeeTreeNode(_childNode);
            this.DialogResult= DialogResult.OK;
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            txtReportingOfficer.Text = _parentNode.Employee.Name;
            foreach (RoleTreeNode childnode in _parentNode.Employee.RoleNode.ChildNodes)
            {
                cboRole.Items.Add(childnode.Role.Name);
            }
        }
    }
}
