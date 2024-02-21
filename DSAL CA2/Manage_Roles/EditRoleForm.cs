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
    public partial class EditRoleForm : Form
    {
        private Role _oneRole;
        private string parentName;
        public delegate void ModifyItemDelegate(string uuid, string name, bool projectLeader);
        public ModifyItemDelegate ModifyItemCallback;
        public EditRoleForm()
        {
            InitializeComponent();
        }
        public EditRoleForm(string uuid, string name, bool projectLeader, string parentName)
        {
            InitializeComponent();
            this._oneRole = new Role();
            _oneRole.Name = name;
            _oneRole.UUID = uuid;
            _oneRole.ProjectLeaderRole = projectLeader;
            this.parentName = parentName;
        }

        private void EditRoleForm_Load(object sender, EventArgs e)
        {
            this.txtName.Text = _oneRole.Name;
            this.txtUUID.Text = _oneRole.UUID;
            this.txtParent.Text = parentName;
            this.chkProjectLeader.Checked = _oneRole.ProjectLeaderRole;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string uuid = txtUUID.Text.Trim();
            bool projectLeader = chkProjectLeader.Checked;
            if (name != "")
            {
                ModifyItemCallback(uuid, name, projectLeader);
                this.DialogResult = DialogResult.OK;

            }
        }
    }
}
