using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DSAL_CA2.Classes;
using DSAL_CA2.Manage_Employees;

namespace DSAL_CA2
{
    public partial class Manage_Employee : Form
    {
        DataManager _dataManager;
        EmployeeTreeNode _selectedNode;

        AddEmployeeForm _addForm;
        ChangeEmployeeRoleForm _changeRoleForm;
        EditEmployeeDetailsForm _editForm;
        SwapEmployeeForm _swapForm;

        private ContextMenuStrip _employeeMenu;
        //Create menu items
        ToolStripMenuItem _addMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem _updateMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem _updateSubMenuItem1 = new ToolStripMenuItem();
        ToolStripMenuItem _updateSubMenuItem2 = new ToolStripMenuItem();
        ToolStripMenuItem _removeMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem _swapMenuItem = new ToolStripMenuItem();
        public Manage_Employee()
        {
            InitializeComponent();
            _dataManager = new DataManager();
            _dataManager.LoadProjectData();
            _selectedNode = null;
        }
        private void Manage_Employees_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            ((MainForm)this.MdiParent).manage_Employees = null;
        }

        private void Manage_Employees_Load(object sender, EventArgs e)
        {
            RebuildTreeView();
            InitializeMenuTreeView();
        }
        public void InitializeMenuTreeView()
        {

            // Create the ContextMenuStrip.
            _employeeMenu = new ContextMenuStrip();
            _addMenuItem.Text = "Add Employee";
            _updateMenuItem.Text = "Edit Employee";
            _removeMenuItem.Text = "Remove Employee";
            _swapMenuItem.Text = "Swap Employee";
            _updateSubMenuItem1.Text = "Edit Employee Details";
            _updateSubMenuItem2.Text = "Change Role/Reporting Officer";

            // Adding Click Event 
            _employeeMenu.ItemClicked += new ToolStripItemClickedEventHandler(contextMenu_ItemClicked);
            _updateMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler(contextMenu_ItemClicked);

            // Adding logic for context menu opening
            _employeeMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);

            //Add the menu items to the menu.
            _employeeMenu.Items.AddRange(new ToolStripMenuItem[] { _addMenuItem, _updateMenuItem, _removeMenuItem, _swapMenuItem });
            _updateMenuItem.DropDownItems.AddRange(new ToolStripMenuItem[]{ _updateSubMenuItem1, _updateSubMenuItem2 });

            //Set the ContextMenuStrip property 
            treeViewEmployee.ContextMenuStrip = _employeeMenu;
        }
        public void contextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            _selectedNode = (EmployeeTreeNode)treeViewEmployee.SelectedNode;
            txtConsole.Text = "Selected Node: " + _selectedNode.Text;
            if ((item != null) && (_selectedNode != null))
            {
                if (item.Text == "Add Employee")
                {
                    _addForm = new AddEmployeeForm(_selectedNode);
                    _addForm.ShowDialog();
                    treeViewEmployee.ExpandAll();
                    if (_addForm.DialogResult == DialogResult.OK)
                    {
                        txtConsole.Text = "Added Employee Successfully\nNew Employee: " + _selectedNode.LastNode.Text;
                    }
                    else
                    {
                        txtConsole.Text = "Add Operation Cancelled";
                    }
                }
                if (item.Text == "Edit Employee Details")
                {
                    Employee employee = _selectedNode.Employee;
                    _editForm = new EditEmployeeDetailsForm(employee);
                    _editForm.callback = new EditEmployeeDetailsForm.EditEmployeeDetailsDelegate(this.EditEmployeeDetailsCallbackFn);
                    _editForm.ShowDialog();
                    if (_editForm.DialogResult == DialogResult.OK)
                    {
                        txtConsole.Text = "Edited Employee Successfully";
                    }
                    else
                    {
                        txtConsole.Text = "Edit Operation Cancelled.";
                    }
                }
                if (item.Text == "Change Role/Reporting Officer")
                {
                    Employee employee = _selectedNode.Employee;
                    _changeRoleForm = new ChangeEmployeeRoleForm(employee);
                    _changeRoleForm.callback = new ChangeEmployeeRoleForm.ChangeEmployeeDelegate(this.ChangeRoleReportingOfficerCallbackFn);
                    _changeRoleForm.ShowDialog();
                    if (_changeRoleForm.DialogResult == DialogResult.OK)
                    {
                        txtConsole.Text = "Change Role/Reporting Officer Successfully";
                    }
                    else
                    {
                        txtConsole.Text = "Change Operation Cancelled.";
                    }
                }
                if (item.Text == "Remove Employee")
                {
                    string message = "Are you sure you want to delete this node?";
                    string caption = "Warning";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        txtConsole.Text = "Deleted Node: " + _selectedNode.Text;
                        _dataManager.DeleteEmployeeNode(_selectedNode);
                    }
                }
                if (item.Text == "Swap Employee")
                {
                    _swapForm = new SwapEmployeeForm(_selectedNode);
                    _swapForm.callback = new SwapEmployeeForm.SwapEmployeeDelegate(this.SwapEmployeeCallbackFn);
                    _swapForm.ShowDialog();
                    if (_swapForm.DialogResult == DialogResult.OK)
                    {
                        txtConsole.Text = "Swap Employee Successfully";
                    }
                    else
                    {
                        txtConsole.Text = "Swap Operation Cancelled.";
                    }
                }
            }
        }
        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {
            _selectedNode = (EmployeeTreeNode)treeViewEmployee.SelectedNode;
            foreach (ToolStripMenuItem item in _employeeMenu.Items)
            {
                item.Enabled = true;
            }
            if (_selectedNode.Text == "Root-Root(S$0)")
            {
                this._updateMenuItem.Enabled = false;
                this._removeMenuItem.Enabled = false;
                this._swapMenuItem.Enabled = false;
            }
            if (_selectedNode.Text != "Root-Root(S$0)")
            {
                if (_selectedNode.ChildNodes.Count > 0)
                {
                    this._removeMenuItem.Enabled = false;
                    this._updateSubMenuItem2.Enabled = false;
                }
                if (_selectedNode.Employee.RoleNode.ChildNodes.Count == 0)
                {
                    this._addMenuItem.Enabled = false;
                }
            }
        }

        private void treeViewRole_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _selectedNode = (EmployeeTreeNode)treeViewEmployee.SelectedNode;
            txtConsole.Text = "Selected Node: " + _selectedNode.Text;
            txtUUID.Text = _selectedNode.Employee.UUID;
            txtName.Text = _selectedNode.Employee.Name;
            if (_selectedNode.Employee.ReportingOfficer != null)
            {
                txtReportingOfficer.Text = _selectedNode.Employee.ReportingOfficer.Employee.Name;
            }
            txtSalary.Text = _selectedNode.Employee.Salary.ToString();
            if (_selectedNode.Employee.RoleNode != null)
            {
                txtRole.Text = _selectedNode.Employee.RoleNode.Role.Name;
            }
            for (int i = 0; i < _dataManager.Projects.Count; i++)
            {
                if (_selectedNode.Employee.Name == _dataManager.Projects[i].TeamLeader.Name)
                {
                    txtProject.Text = _dataManager.Projects[i].Name;
                }
            }
            chkDummyData.Checked = _selectedNode.Employee.DummyData;
            chkSalary.Checked = _selectedNode.Employee.SalaryAccountable;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtConsole.Text = "Saved Successfully.";
            _dataManager.SaveEmployeeData();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            _dataManager.LoadEmployeeData();
            treeViewEmployee.Nodes.Clear();
            treeViewEmployee.Nodes.Add(_dataManager.EmployeeTreeStructure);
            treeViewEmployee.ExpandAll();
            txtConsole.Text = "Loaded Successfully.";
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            treeViewEmployee.ExpandAll();
            txtConsole.Text = "Tree View Expanded.";
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            treeViewEmployee.CollapseAll();
            txtConsole.Text = "Tree View Collapsed.";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            treeViewEmployee.Nodes.Clear();
            _dataManager.resetEmployeeData();
            treeViewEmployee.Nodes.Add(_dataManager.EmployeeTreeStructure);
            treeViewEmployee.ExpandAll();
            txtConsole.Text = "Tree View Reset.";
        }
        private void EditEmployeeDetailsCallbackFn(string uuid, string name, double salary, bool dummyData)
        {
            List<EmployeeTreeNode> resultNodes = new List<EmployeeTreeNode>();
            _dataManager.EmployeeTreeStructure.SearchByUUID(uuid, ref resultNodes);
            resultNodes[0].Employee.Name = name;
            resultNodes[0].Employee.Salary = salary;
            resultNodes[0].Employee.DummyData = dummyData;
            resultNodes[0].Text = name + "-" + resultNodes[0].Employee.RoleNode.Role.Name + "(S$" + salary + ")";
        }
        private void ChangeRoleReportingOfficerCallbackFn(string uuid, EmployeeTreeNode reportingOfficer, RoleTreeNode role)
        {
            List<EmployeeTreeNode> resultNodes = new List<EmployeeTreeNode>();
            _dataManager.EmployeeTreeStructure.SearchByUUID(uuid, ref resultNodes);
            resultNodes[0].Employee.ReportingOfficer = reportingOfficer;
            resultNodes[0].Employee.RoleNode = role;
            resultNodes[0].Text = resultNodes[0].Employee.Name + "-" + role.Role.Name + "(S$" + resultNodes[0].Employee.Salary + ")";
        }
        private void SwapEmployeeCallbackFn(EmployeeTreeNode e1, EmployeeTreeNode e2)
        {
            EmployeeTreeNode temp = new EmployeeTreeNode();
            EmployeeTreeNode temp2 = new EmployeeTreeNode();
            temp = (EmployeeTreeNode)e1.Clone();
            e1 = (EmployeeTreeNode)e2.Clone();
            e2 = (EmployeeTreeNode)temp.Clone();
        }
        private void RebuildTreeView()
        {
            treeViewEmployee.Nodes.Clear();
            treeViewEmployee.Nodes.Add(_dataManager.EmployeeTreeStructure);
            treeViewEmployee.ExpandAll();
        }
    }
}
