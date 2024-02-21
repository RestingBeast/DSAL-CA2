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
    public partial class AddRoleForm : Form
    {
        private RoleTreeNode _childNode;
        private RoleTreeNode _parentNode;
        public AddRoleForm()
        {
            InitializeComponent();
        }
        public AddRoleForm(RoleTreeNode _roleNode)
        {
            InitializeComponent();
            this._parentNode = _roleNode;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AddRoleForm_Load(object sender, EventArgs e)
        {
            txtParent.Text = _parentNode.Role.Name;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Role tempRole = new Role(txtName.Text);
            if (chkProjectLeader.Checked)
            {
                tempRole.ProjectLeaderRole = true;
            }
            _childNode = new RoleTreeNode(tempRole);
            _parentNode.AddChildRoleTreeNode(_childNode);
            this.DialogResult = DialogResult.OK;
        }
    }
}
