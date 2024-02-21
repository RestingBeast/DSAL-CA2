namespace DSAL_CA2
{
    partial class Manage_Employee
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
            this.treeViewEmployee = new System.Windows.Forms.TreeView();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkSalary = new System.Windows.Forms.CheckBox();
            this.chkDummyData = new System.Windows.Forms.CheckBox();
            this.txtReportingOfficer = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtUUID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewEmployee
            // 
            this.treeViewEmployee.Location = new System.Drawing.Point(448, 78);
            this.treeViewEmployee.Name = "treeViewEmployee";
            this.treeViewEmployee.Size = new System.Drawing.Size(763, 500);
            this.treeViewEmployee.TabIndex = 21;
            this.treeViewEmployee.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewRole_AfterSelect);
            // 
            // txtConsole
            // 
            this.txtConsole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtConsole.Location = new System.Drawing.Point(15, 447);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(398, 131);
            this.txtConsole.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(432, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Right Click to perform actions such as edit, remove or add roles ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(448, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Root Node Tree View";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Console";
            // 
            // btnCollapse
            // 
            this.btnCollapse.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCollapse.ForeColor = System.Drawing.Color.White;
            this.btnCollapse.Location = new System.Drawing.Point(1095, 34);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(116, 29);
            this.btnCollapse.TabIndex = 16;
            this.btnCollapse.Text = "Collapse All";
            this.btnCollapse.UseVisualStyleBackColor = false;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExpand.ForeColor = System.Drawing.Color.White;
            this.btnExpand.Location = new System.Drawing.Point(949, 34);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(126, 29);
            this.btnExpand.TabIndex = 15;
            this.btnExpand.Text = "Expand All";
            this.btnExpand.UseVisualStyleBackColor = false;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(291, 373);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(122, 29);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.MediumBlue;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(12, 373);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(122, 29);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(152, 373);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 29);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chkSalary);
            this.panel1.Controls.Add(this.chkDummyData);
            this.panel1.Controls.Add(this.txtReportingOfficer);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtProject);
            this.panel1.Controls.Add(this.txtRole);
            this.panel1.Controls.Add(this.txtSalary);
            this.panel1.Controls.Add(this.txtUUID);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 350);
            this.panel1.TabIndex = 11;
            // 
            // chkSalary
            // 
            this.chkSalary.AutoSize = true;
            this.chkSalary.Enabled = false;
            this.chkSalary.Location = new System.Drawing.Point(196, 277);
            this.chkSalary.Name = "chkSalary";
            this.chkSalary.Size = new System.Drawing.Size(165, 24);
            this.chkSalary.TabIndex = 6;
            this.chkSalary.Text = "Salary Accountable?";
            this.chkSalary.UseVisualStyleBackColor = true;
            // 
            // chkDummyData
            // 
            this.chkDummyData.AutoSize = true;
            this.chkDummyData.Enabled = false;
            this.chkDummyData.Location = new System.Drawing.Point(28, 277);
            this.chkDummyData.Name = "chkDummyData";
            this.chkDummyData.Size = new System.Drawing.Size(126, 24);
            this.chkDummyData.TabIndex = 6;
            this.chkDummyData.Text = "Dummy Data?";
            this.chkDummyData.UseVisualStyleBackColor = true;
            // 
            // txtReportingOfficer
            // 
            this.txtReportingOfficer.Enabled = false;
            this.txtReportingOfficer.Location = new System.Drawing.Point(196, 87);
            this.txtReportingOfficer.Name = "txtReportingOfficer";
            this.txtReportingOfficer.ReadOnly = true;
            this.txtReportingOfficer.Size = new System.Drawing.Size(160, 27);
            this.txtReportingOfficer.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(196, 123);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(160, 27);
            this.txtName.TabIndex = 4;
            // 
            // txtProject
            // 
            this.txtProject.Enabled = false;
            this.txtProject.Location = new System.Drawing.Point(196, 237);
            this.txtProject.Name = "txtProject";
            this.txtProject.ReadOnly = true;
            this.txtProject.Size = new System.Drawing.Size(160, 27);
            this.txtProject.TabIndex = 4;
            // 
            // txtRole
            // 
            this.txtRole.Enabled = false;
            this.txtRole.Location = new System.Drawing.Point(196, 199);
            this.txtRole.Name = "txtRole";
            this.txtRole.ReadOnly = true;
            this.txtRole.Size = new System.Drawing.Size(160, 27);
            this.txtRole.TabIndex = 4;
            // 
            // txtSalary
            // 
            this.txtSalary.Enabled = false;
            this.txtSalary.Location = new System.Drawing.Point(196, 160);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            this.txtSalary.Size = new System.Drawing.Size(160, 27);
            this.txtSalary.TabIndex = 4;
            // 
            // txtUUID
            // 
            this.txtUUID.Enabled = false;
            this.txtUUID.Location = new System.Drawing.Point(196, 50);
            this.txtUUID.Name = "txtUUID";
            this.txtUUID.ReadOnly = true;
            this.txtUUID.Size = new System.Drawing.Size(160, 27);
            this.txtUUID.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(129, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Read-Only";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(28, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Project:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(28, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Role:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(28, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Salary(S$):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(28, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Reporting Officer:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(28, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(28, 53);
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
            // Manage_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 598);
            this.Controls.Add(this.treeViewEmployee);
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
            this.Name = "Manage_Employee";
            this.Text = "Manage_Employees";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manage_Employees_FormClosing_1);
            this.Load += new System.EventHandler(this.Manage_Employees_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewEmployee;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkDummyData;
        private System.Windows.Forms.TextBox txtReportingOfficer;
        private System.Windows.Forms.TextBox txtUUID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkSalary;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.TextBox txtRole;
    }
}