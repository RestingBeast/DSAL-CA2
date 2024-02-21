namespace DSAL_CA2.Manage_Employees
{
    partial class ChangeEmployeeRoleForm
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
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUUID = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.chkSalary = new System.Windows.Forms.CheckBox();
            this.chkDummyData = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboReportingOfficer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboRole
            // 
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Location = new System.Drawing.Point(184, 225);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(194, 28);
            this.cboRole.TabIndex = 44;
            // 
            // txtSalary
            // 
            this.txtSalary.Enabled = false;
            this.txtSalary.Location = new System.Drawing.Point(184, 179);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            this.txtSalary.Size = new System.Drawing.Size(194, 27);
            this.txtSalary.TabIndex = 42;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(184, 133);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(194, 27);
            this.txtName.TabIndex = 43;
            // 
            // txtUUID
            // 
            this.txtUUID.Enabled = false;
            this.txtUUID.Location = new System.Drawing.Point(184, 44);
            this.txtUUID.Name = "txtUUID";
            this.txtUUID.ReadOnly = true;
            this.txtUUID.Size = new System.Drawing.Size(194, 27);
            this.txtUUID.TabIndex = 40;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(211, 323);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(167, 29);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(14, 323);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(167, 29);
            this.btnChange.TabIndex = 38;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // chkSalary
            // 
            this.chkSalary.AutoSize = true;
            this.chkSalary.Checked = true;
            this.chkSalary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSalary.Enabled = false;
            this.chkSalary.Location = new System.Drawing.Point(184, 276);
            this.chkSalary.Name = "chkSalary";
            this.chkSalary.Size = new System.Drawing.Size(165, 24);
            this.chkSalary.TabIndex = 36;
            this.chkSalary.Text = "Salary Accountable?";
            this.chkSalary.UseVisualStyleBackColor = true;
            // 
            // chkDummyData
            // 
            this.chkDummyData.AutoSize = true;
            this.chkDummyData.Enabled = false;
            this.chkDummyData.Location = new System.Drawing.Point(14, 276);
            this.chkDummyData.Name = "chkDummyData";
            this.chkDummyData.Size = new System.Drawing.Size(126, 24);
            this.chkDummyData.TabIndex = 37;
            this.chkDummyData.Text = "Dummy Data?";
            this.chkDummyData.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Role";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(14, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "UUID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Reporting Officer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Change Role and/or Reporting Officer";
            // 
            // cboReportingOfficer
            // 
            this.cboReportingOfficer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReportingOfficer.FormattingEnabled = true;
            this.cboReportingOfficer.Location = new System.Drawing.Point(184, 89);
            this.cboReportingOfficer.Name = "cboReportingOfficer";
            this.cboReportingOfficer.Size = new System.Drawing.Size(194, 28);
            this.cboReportingOfficer.TabIndex = 44;
            // 
            // ChangeEmployeeRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 377);
            this.Controls.Add(this.cboReportingOfficer);
            this.Controls.Add(this.cboRole);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtUUID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.chkSalary);
            this.Controls.Add(this.chkDummyData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangeEmployeeRoleForm";
            this.Text = "Change Role and/or Reporting Officer";
            this.Load += new System.EventHandler(this.ChangeEmployeeRoleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUUID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.CheckBox chkSalary;
        private System.Windows.Forms.CheckBox chkDummyData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboReportingOfficer;
    }
}