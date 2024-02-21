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
    public partial class SwapEmployeeForm : Form
    {
        DataManager _dataManager = new DataManager();
        EmployeeTreeNode _selectedNode, _employeeNode;
        public delegate void SwapEmployeeDelegate(EmployeeTreeNode e1, EmployeeTreeNode e2);
        public SwapEmployeeDelegate callback;
        public SwapEmployeeForm()
        {
            InitializeComponent();
        }
        public SwapEmployeeForm(EmployeeTreeNode employeeNode)
        {
            InitializeComponent();
            _employeeNode = employeeNode;
        }

        private void SwapEmployeeForm_Load(object sender, EventArgs e)
        {
            treeViewEmployee.Nodes.Clear();
            treeViewEmployee.Nodes.Add(_dataManager.EmployeeTreeStructure);
            treeViewEmployee.ExpandAll();
            txtEmployee.Text = _employeeNode.Text;
        }

        private void treeViewEmployee_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _selectedNode = (EmployeeTreeNode)treeViewEmployee.SelectedNode;
            txtUUID.Text = _selectedNode.Employee.UUID;
            txtName.Text = _selectedNode.Employee.Name;
            txtSalary.Text = _selectedNode.Employee.Salary.ToString();
            if (_selectedNode.Employee.ReportingOfficer != null)
            {
                txtReportingOfficer.Text = _selectedNode.Employee.ReportingOfficer.Employee.Name;
            }
            if (_selectedNode.Employee.RoleNode != null)
            {
                txtRole.Text = _selectedNode.Employee.RoleNode.Role.Name;
            }
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            callback(_employeeNode, _selectedNode);
            this.DialogResult = DialogResult.OK;
        }
    }
}
