namespace DSAL_CA2.Manage_Employees
{
    partial class AddEmployeeForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtReportingOfficer = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.chkDummyData = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.chkSalary = new System.Windows.Forms.CheckBox();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(186, 83);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(194, 27);
            this.txtName.TabIndex = 15;
            // 
            // txtReportingOfficer
            // 
            this.txtReportingOfficer.Enabled = false;
            this.txtReportingOfficer.Location = new System.Drawing.Point(186, 39);
            this.txtReportingOfficer.Name = "txtReportingOfficer";
            this.txtReportingOfficer.ReadOnly = true;
            this.txtReportingOfficer.Size = new System.Drawing.Size(194, 27);
            this.txtReportingOfficer.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(213, 273);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(167, 29);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(16, 273);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(167, 29);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chkDummyData
            // 
            this.chkDummyData.AutoSize = true;
            this.chkDummyData.Location = new System.Drawing.Point(16, 226);
            this.chkDummyData.Name = "chkDummyData";
            this.chkDummyData.Size = new System.Drawing.Size(126, 24);
            this.chkDummyData.TabIndex = 11;
            this.chkDummyData.Text = "Dummy Data?";
            this.chkDummyData.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Reporting Officer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Add Employee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(16, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(16, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Role";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(186, 129);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(194, 27);
            this.txtSalary.TabIndex = 15;
            // 
            // chkSalary
            // 
            this.chkSalary.AutoSize = true;
            this.chkSalary.Checked = true;
            this.chkSalary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSalary.Enabled = false;
            this.chkSalary.Location = new System.Drawing.Point(186, 226);
            this.chkSalary.Name = "chkSalary";
            this.chkSalary.Size = new System.Drawing.Size(165, 24);
            this.chkSalary.TabIndex = 11;
            this.chkSalary.Text = "Salary Accountable?";
            this.chkSalary.UseVisualStyleBackColor = true;
            // 
            // cboRole
            // 
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Location = new System.Drawing.Point(186, 175);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(194, 28);
            this.cboRole.TabIndex = 16;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 343);
            this.Controls.Add(this.cboRole);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtReportingOfficer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chkSalary);
            this.Controls.Add(this.chkDummyData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEmployeeForm";
            this.Text = "Add_New_Employee";
            this.Load += new System.EventHandler(this.AddEmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtReportingOfficer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox chkDummyData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.CheckBox chkSalary;
        private System.Windows.Forms.ComboBox cboRole;
    }
}