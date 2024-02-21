using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DSAL_CA2
{
    public partial class MainForm : Form
    {
        public Manage_Roles manage_Roles;
        public Manage_Employee manage_Employees;
        public Manage_Projects manage_Projects;
        public MainForm()
        {
            InitializeComponent();
        }

        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (manage_Roles != null)
            {
                manage_Roles.Show();
            } else
            {
                manage_Roles = new Manage_Roles();
                manage_Roles.MdiParent = this;
                manage_Roles.Show();
            }                
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (manage_Employees != null)
            {
                manage_Employees.Show();
            }
            else
            {
                manage_Employees = new Manage_Employee();
                manage_Employees.MdiParent = this;
                manage_Employees.Show();
            }
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (manage_Projects != null)
            {
                manage_Projects.Show();
            }
            else
            {
                manage_Projects = new Manage_Projects();
                manage_Projects.MdiParent = this;
                manage_Projects.Show();
            }
        }
    }
}
