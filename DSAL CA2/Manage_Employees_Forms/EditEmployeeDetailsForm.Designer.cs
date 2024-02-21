namespace DSAL_CA2.Manage_Employees
{
    partial class EditEmployeeDetailsForm
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
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtReportingOfficer = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.chkSalary = new System.Windows.Forms.CheckBox();
            this.chkDummyData = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUUID = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(189, 179);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(194, 27);
            this.txtSalary.TabIndex = 27;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(189, 133);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(194, 27);
            this.txtName.TabIndex = 28;
            // 
            // txtReportingOfficer
            // 
            this.txtReportingOfficer.Enabled = false;
            this.txtReportingOfficer.Location = new System.Drawing.Point(189, 89);
            this.txtReportingOfficer.Name = "txtReportingOfficer";
            this.txtReportingOfficer.ReadOnly = true;
            this.txtReportingOfficer.Size = new System.Drawing.Size(194, 27);
            this.txtReportingOfficer.TabIndex = 26;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(216, 323);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(167, 29);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(19, 323);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(167, 29);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // chkSalary
            // 
            this.chkSalary.AutoSize = true;
            this.chkSalary.Checked = true;
            this.chkSalary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSalary.Enabled = false;
            this.chkSalary.Location = new System.Drawing.Point(189, 276);
            this.chkSalary.Name = "chkSalary";
            this.chkSalary.Size = new System.Drawing.Size(165, 24);
            this.chkSalary.TabIndex = 22;
            this.chkSalary.Text = "Salary Accountable?";
            this.chkSalary.UseVisualStyleBackColor = true;
            // 
            // chkDummyData
            // 
            this.chkDummyData.AutoSize = true;
            this.chkDummyData.Location = new System.Drawing.Point(19, 276);
            this.chkDummyData.Name = "chkDummyData";
            this.chkDummyData.Size = new System.Drawing.Size(126, 24);
            this.chkDummyData.TabIndex = 23;
            this.chkDummyData.Text = "Dummy Data?";
            this.chkDummyData.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Role";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(19, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Reporting Officer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(189, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Edit_Employee_Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(19, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "UUID";
            // 
            // txtUUID
            // 
            this.txtUUID.Enabled = false;
            this.txtUUID.Location = new System.Drawing.Point(189, 44);
            this.txtUUID.Name = "txtUUID";
            this.txtUUID.ReadOnly = true;
            this.txtUUID.Size = new System.Drawing.Size(194, 27);
            this.txtUUID.TabIndex = 26;
            // 
            // txtRole
            // 
            this.txtRole.Enabled = false;
            this.txtRole.Location = new System.Drawing.Point(189, 225);
            this.txtRole.Name = "txtRole";
            this.txtRole.ReadOnly = true;
            this.txtRole.Size = new System.Drawing.Size(194, 27);
            this.txtRole.TabIndex = 26;
            // 
            // EditEmployeeDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 379);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtUUID);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtReportingOfficer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.chkSalary);
            this.Controls.Add(this.chkDummyData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditEmployeeDetailsForm";
            this.Text = "Edit_Employee_Details";
            this.Load += new System.EventHandler(this.EditEmployeeDetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtReportingOfficer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.CheckBox chkSalary;
        private System.Windows.Forms.CheckBox chkDummyData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUUID;
        private System.Windows.Forms.TextBox txtRole;
    }
}