namespace DSAL_CA2.Manage_Employees
{
    partial class SwapEmployeeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.treeViewEmployee = new System.Windows.Forms.TreeView();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSwap = new System.Windows.Forms.Button();
            this.txtReportingOfficer = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtProjects = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtUUID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "You are replacing";
            // 
            // txtEmployee
            // 
            this.txtEmployee.Enabled = false;
            this.txtEmployee.Location = new System.Drawing.Point(142, 40);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(206, 27);
            this.txtEmployee.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select employee node to replace with:";
            // 
            // treeViewEmployee
            // 
            this.treeViewEmployee.Location = new System.Drawing.Point(12, 137);
            this.treeViewEmployee.Name = "treeViewEmployee";
            this.treeViewEmployee.Size = new System.Drawing.Size(414, 388);
            this.treeViewEmployee.TabIndex = 4;
            this.treeViewEmployee.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewEmployee_AfterSelect);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(143, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Replace With";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(32, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Reporting Officer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(32, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(32, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(32, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Role";
            // 
            // btnSwap
            // 
            this.btnSwap.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnSwap.ForeColor = System.Drawing.Color.White;
            this.btnSwap.Location = new System.Drawing.Point(125, 323);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(167, 29);
            this.btnSwap.TabIndex = 24;
            this.btnSwap.Text = "Swap";
            this.btnSwap.UseVisualStyleBackColor = false;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // txtReportingOfficer
            // 
            this.txtReportingOfficer.Enabled = false;
            this.txtReportingOfficer.Location = new System.Drawing.Point(202, 88);
            this.txtReportingOfficer.Name = "txtReportingOfficer";
            this.txtReportingOfficer.ReadOnly = true;
            this.txtReportingOfficer.Size = new System.Drawing.Size(194, 27);
            this.txtReportingOfficer.TabIndex = 26;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(202, 132);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(194, 27);
            this.txtName.TabIndex = 28;
            // 
            // txtSalary
            // 
            this.txtSalary.Enabled = false;
            this.txtSalary.Location = new System.Drawing.Point(202, 178);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            this.txtSalary.Size = new System.Drawing.Size(194, 27);
            this.txtSalary.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtProjects);
            this.panel1.Controls.Add(this.txtRole);
            this.panel1.Controls.Add(this.txtSalary);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.btnSwap);
            this.panel1.Controls.Add(this.txtUUID);
            this.panel1.Controls.Add(this.txtReportingOfficer);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(444, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 388);
            this.panel1.TabIndex = 5;
            // 
            // txtProjects
            // 
            this.txtProjects.Enabled = false;
            this.txtProjects.Location = new System.Drawing.Point(202, 271);
            this.txtProjects.Name = "txtProjects";
            this.txtProjects.ReadOnly = true;
            this.txtProjects.Size = new System.Drawing.Size(194, 27);
            this.txtProjects.TabIndex = 27;
            // 
            // txtRole
            // 
            this.txtRole.Enabled = false;
            this.txtRole.Location = new System.Drawing.Point(202, 224);
            this.txtRole.Name = "txtRole";
            this.txtRole.ReadOnly = true;
            this.txtRole.Size = new System.Drawing.Size(194, 27);
            this.txtRole.TabIndex = 27;
            // 
            // txtUUID
            // 
            this.txtUUID.Enabled = false;
            this.txtUUID.Location = new System.Drawing.Point(202, 47);
            this.txtUUID.Name = "txtUUID";
            this.txtUUID.ReadOnly = true;
            this.txtUUID.Size = new System.Drawing.Size(194, 27);
            this.txtUUID.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(32, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Projects";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(32, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "UUID";
            // 
            // SwapEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeViewEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SwapEmployeeForm";
            this.Text = "SwapEmployeeForm";
            this.Load += new System.EventHandler(this.SwapEmployeeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView treeViewEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.TextBox txtReportingOfficer;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtProjects;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtUUID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}