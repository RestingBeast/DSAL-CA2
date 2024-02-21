using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DSAL_CA2.Classes;

namespace DSAL_CA2
{
    public partial class Manage_Roles : Form
    {
        DataManager _dataManager;
        RoleTreeNode _selectedNode;
        AddRoleForm _addRoleForm;
        EditRoleForm _editRoleForm;

        private ContextMenuStrip _roleMenu;
        //Create menu items
        ToolStripMenuItem _addMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem _updateMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem _removeMenuItem = new ToolStripMenuItem();

        public Manage_Roles()
        {
            InitializeComponent();
            _dataManager = new DataManager();
            _selectedNode = null;
        }

        private void Manage_Roles_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)this.MdiParent).manage_Roles = null;
        }

        private void Manage_Roles_Load(object sender, EventArgs e)
        {
            Rebuild_TreeView();
            InitializeMenuTreeView();
        }
        private void treeViewRole_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _selectedNode = (RoleTreeNode)treeViewRole.SelectedNode;
            txtUUID.Text = _selectedNode.Role.UUID;
            txtName.Text = _selectedNode.Role.Name;
            chkProjectLeader.Checked = _selectedNode.Role.ProjectLeaderRole;
        }
        public void InitializeMenuTreeView()
        {

            // Create the ContextMenuStrip.
            _roleMenu = new ContextMenuStrip();
            _addMenuItem.Text = "Add Role";   
            _updateMenuItem.Text = "Edit Role";
            _removeMenuItem.Text = "Remove Node";

            // Adding Click Event 
            _roleMenu.ItemClicked += new ToolStripItemClickedEventHandler(contextMenu_ItemClicked);
          
            // Adding logic for context menu opening
            _roleMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);

            //Add the menu items to the menu.
            _roleMenu.Items.AddRange(new ToolStripMenuItem[] { _addMenuItem, _updateMenuItem, _removeMenuItem });
            //Set the ContextMenuStrip property 
            treeViewRole.ContextMenuStrip = _roleMenu;
        }
        public void contextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            _selectedNode = (RoleTreeNode)treeViewRole.SelectedNode;
            txtConsole.Text = "Selected Node: " + _selectedNode.Text;
            if ((item != null) && (_selectedNode != null))
            {
                if (item.Text == "Add Role")
                {
                    _addRoleForm = new AddRoleForm(_selectedNode);
                    _addRoleForm.ShowDialog();
                    treeViewRole.ExpandAll();
                    if (_addRoleForm.DialogResult == DialogResult.OK)
                    {
                        txtConsole.Text = "Added Role Successfully\nNew Role: " + _selectedNode.LastNode.Text;
                    }
                    else
                    {
                        txtConsole.Text = "Add Operation Cancelled";
                    }
                }
                if (item.Text == "Edit Role")
                {
                    Role role = _selectedNode.Role;
                    string parentName = _selectedNode.ParentNode.Role.Name;

                    _editRoleForm = new EditRoleForm(role.UUID, role.Name, role.ProjectLeaderRole, parentName);
                    _editRoleForm.ModifyItemCallback = new EditRoleForm.ModifyItemDelegate(this.ModifyItemCallbackFn);
                    _editRoleForm.ShowDialog();
                    if (_editRoleForm.DialogResult == DialogResult.OK)
                    {
                        txtConsole.Text = "Edited Role Successfully\nRole UUID: " + _selectedNode.Role.UUID
                            + "\nRole Name: " + _selectedNode.Role.Name + "\nProject Leader?: " 
                            + _selectedNode.Role.ProjectLeaderRole;
                    }
                    else
                    {
                        txtConsole.Text = "Edit Operation Cancelled.";
                    }
                }
                if (item.Text == "Remove Node")
                {
                    List<EmployeeTreeNode> employees = new List<EmployeeTreeNode>();
                    _dataManager.EmployeeTreeStructure.SearchByRole(_selectedNode, ref employees);
                    if (employees.Count > 0)
                    {
                        string message = "There are one or more employees with this role. Cannot be deleted!";
                        string caption = "Invalid";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;

                        MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);

                        txtConsole.Text = "Failed to remove Node.\nThere are one or more employees with this role.";
                    }
                    else
                    {
                        string message = "Are you sure you want to delete this node?";
                        string caption = "Warning";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result;

                        result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            txtConsole.Text = "Deleted Node: " + _selectedNode.Text;
                            _dataManager.DeleteRoleNode(_selectedNode);
                        }
                    }
                    
                }
            }
        }
        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {
            _selectedNode = (RoleTreeNode)treeViewRole.SelectedNode;
            foreach (ToolStripMenuItem item in _roleMenu.Items)
            {
                item.Enabled = true;
            }
            if (_selectedNode.Text == "Root")
            {
                this._updateMenuItem.Enabled = false;
                this._removeMenuItem.Enabled = false;
            }
            if (_selectedNode.Text != "Root")
            {
                if (_selectedNode.ChildNodes.Count > 0)
                {
                    this._removeMenuItem.Enabled = false;
                }
                
            }
        }
        private void ModifyItemCallbackFn(string uuid, string name, bool projectLeader)
        {
            List<RoleTreeNode> resultNodes = new List<RoleTreeNode>();
            _dataManager.RoleTreeStructure.SearchByUUID(uuid, ref resultNodes);
            resultNodes[0].Role.Name = name;
            resultNodes[0].Role.ProjectLeaderRole = projectLeader;
            resultNodes[0].Text = name;
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            this.treeViewRole.ExpandAll();
            txtConsole.Text = "Tree View Expanded";
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            this.treeViewRole.CollapseAll();
            txtConsole.Text = "Tree View Collapsed";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _dataManager.SaveRoleData();
            txtConsole.Text = "Saved Role Data.";
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            _dataManager.LoadRoleData();
            Rebuild_TreeView();
            txtConsole.Text = "Loaded Role Data.";
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            _dataManager.resetRoleData();
            Rebuild_TreeView();
            txtConsole.Text = "Reset Role Data.";
        }
        private void Rebuild_TreeView()
        {
            treeViewRole.Nodes.Clear();
            treeViewRole.Nodes.Add(_dataManager.RoleTreeStructure);
            treeViewRole.ExpandAll();
        }
    }
}
