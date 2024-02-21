namespace DSAL_CA2
{
    partial class Manage_Roles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkProjectLeader = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUUID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.treeViewRole = new System.Windows.Forms.TreeView();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chkProjectLeader);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtUUID);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 196);
            this.panel1.TabIndex = 0;
            // 
            // chkProjectLeader
            // 
            this.chkProjectLeader.AutoSize = true;
            this.chkProjectLeader.Enabled = false;
            this.chkProjectLeader.Location = new System.Drawing.Point(43, 135);
            this.chkProjectLeader.Name = "chkProjectLeader";
            this.chkProjectLeader.Size = new System.Drawing.Size(167, 24);
            this.chkProjectLeader.TabIndex = 6;
            this.chkProjectLeader.Text = "Project Leader Role?";
            this.chkProjectLeader.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(196, 95);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(160, 27);
            this.txtName.TabIndex = 5;
            // 
            // txtUUID
            // 
            this.txtUUID.Enabled = false;
            this.txtUUID.Location = new System.Drawing.Point(196, 53);
            this.txtUUID.Name = "txtUUID";
            this.txtUUID.ReadOnly = true;
            this.txtUUID.Size = new System.Drawing.Size(160, 27);
            this.txtUUID.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(145, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Read-Only";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(42, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(46, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "UUID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(71, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Selected Node Role Information";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(152, 223);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 29);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(291, 223);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(122, 29);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExpand.ForeColor = System.Drawing.Color.White;
            this.btnExpand.Location = new System.Drawing.Point(949, 34);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(126, 29);
            this.btnExpand.TabIndex = 4;
            this.btnExpand.Text = "Expand All";
            this.btnExpand.UseVisualStyleBackColor = false;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // btnCollapse
            // 
            this.btnCollapse.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCollapse.ForeColor = System.Drawing.Color.White;
            this.btnCollapse.Location = new System.Drawing.Point(1095, 34);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(116, 29);
            this.btnCollapse.TabIndex = 5;
            this.btnCollapse.Text = "Collapse All";
            this.btnCollapse.UseVisualStyleBackColor = false;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Console";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(448, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Root Node Tree View";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(432, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Right Click to perform actions such as edit, remove or add roles ";
            // 
            // txtConsole
            // 
            this.txtConsole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtConsole.Location = new System.Drawing.Point(15, 299);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(398, 190);
            this.txtConsole.TabIndex = 9;
            this.txtConsole.Text = "Roles cannot be added if there are projects assigned.\r\nRoles cannot be removed if" +
    " there are employees under it.\r\nOnly one level of role is allowed under a projec" +
    "t leader role.\r\n";
            // 
            // treeViewRole
            // 
            this.treeViewRole.Location = new System.Drawing.Point(448, 78);
            this.treeViewRole.Name = "treeViewRole";
            this.treeViewRole.Size = new System.Drawing.Size(763, 411);
            this.treeViewRole.TabIndex = 10;
            this.treeViewRole.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewRole_AfterSelect);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.MediumBlue;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(12, 223);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(122, 29);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Manage_Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 506);
            this.Controls.Add(this.treeViewRole);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCollapse);
            this.Controls.Add(this.btnExpand);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Name = "Manage_Roles";
            this.Text = "Manage_Roles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manage_Roles_FormClosing);
            this.Load += new System.EventHandler(this.Manage_Roles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUUID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.TreeView treeViewRole;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox chkProjectLeader;
    }
}