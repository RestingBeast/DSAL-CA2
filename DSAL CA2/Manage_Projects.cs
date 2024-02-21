using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DSAL_CA2.Classes;

namespace DSAL_CA2
{
    public partial class Manage_Projects : Form
    {
        DataManager _dataManager;
        public Manage_Projects()
        {
            InitializeComponent();
            _dataManager = new DataManager();
        }

        private void Manage_Projects_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)this.MdiParent).manage_Projects = null;
        }

        private void Manage_Projects_Load(object sender, EventArgs e)
        {
            cboMode.SelectedIndex = 0;
            treeViewEmployee.Nodes.Clear();
            treeViewEmployee.Nodes.Add(_dataManager.EmployeeTreeStructure);
            treeViewEmployee.ExpandAll();
            loadProjectData();
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
        }

        private void cboMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboMode.SelectedIndex)
            {
                case 0: 
                    pnlAdd.Enabled = false;
                    pnlEdit.Enabled = false;
                    txtConsole.Text = "View Mode";
                    break;
                case 1: 
                    pnlAdd.Enabled = true;
                    pnlEdit.Enabled = false;
                    txtConsole.Text = "Add Mode";
                    break;
                case 2:
                    pnlAdd.Enabled = false;
                    pnlEdit.Enabled = true;
                    txtConsole.Text = "Edit Mode";
                    break;
            }
        }
        private void resetAddForm()
        {
            txtProjectName.Text = "";
            txtRevenue.Text = "";
            cboTeamLeader.Items.Clear();
        }
        private void resetEditForm()
        {
            txtUUID.Text = "";
            txtProjectName_view.Text = "";
            txtRevenue_view.Text = "";
            cboTeamLeader_view.Items.Clear();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetAddForm();
            txtConsole.Text = "Add Operation Cancelled";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Project p = new Project();
            EmployeeTreeNode foundNode = new EmployeeTreeNode();
            _dataManager.EmployeeTreeStructure.SearchByName(cboTeamLeader.Text, ref foundNode);
            p.Name = txtProjectName.Text;
            p.Revenue = Double.Parse(txtRevenue.Text);
            p.TeamLeader = foundNode.Employee;
            _dataManager.Projects.Add(p);
            listViewProjects.Items.Add(new ListViewItem(new String[]
                    {
                        p.Name,
                        p.UUID,
                        p.Revenue.ToString(),
                        p.TeamLeader.Name,
                    }));
            resetAddForm();
            txtConsole.Text = "Added Successfully";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listViewProjects.SelectedItems.Count > 0)
            {
                Project p = _dataManager.Projects[listViewProjects.SelectedIndices[0]];
                EmployeeTreeNode foundNode = new EmployeeTreeNode();
                _dataManager.EmployeeTreeStructure.SearchByName(cboTeamLeader_view.Text , ref foundNode);
                p.Name = txtProjectName_view.Text;
                p.Revenue = Double.Parse(txtRevenue_view.Text);
                p.TeamLeader = foundNode.Employee;
                resetEditForm();
                listViewProjects.Items.Clear();
                listViewProjects.Items.AddRange(_dataManager.Projects.Select(p => new ListViewItem(new String[]
                {
                    p.Name,
                    p.UUID,
                    p.Revenue.ToString(),
                    p.TeamLeader.Name,
                })).ToArray());
                txtConsole.Text = "Edited Successfully";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewProjects.SelectedItems.Count > 0)
            {
                Project p = _dataManager.Projects[listViewProjects.SelectedIndices[0]];
                _dataManager.Projects.Remove(p);
                resetEditForm();
                listViewProjects.Items.Clear();
                listViewProjects.Items.AddRange(_dataManager.Projects.Select(p => new ListViewItem(new String[]
                {
                    p.Name,
                    p.UUID,
                    p.Revenue.ToString(),
                    p.TeamLeader.Name,
                })).ToArray());
                txtConsole.Text = "Deleted Successfully";
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadProjectData();
            txtConsole.Text = "Loaded Successfully";
        }
        private void txtRevenue_TextChanged(object sender, EventArgs e)
        {
            cboTeamLeader.Items.Clear();
            if (txtRevenue.Text != "")
            {
                GetTeamLeader(_dataManager.EmployeeTreeStructure, txtRevenue, cboTeamLeader);
            }
            
        }
        private void GetTeamLeader(EmployeeTreeNode employee, TextBox textbox, ComboBox comboBox)
        {
            int employeeCount = employee.ChildNodes.Count;
            List<EmployeeTreeNode> childNodes = employee.ChildNodes;
            if (employeeCount > 0)
            {
                int i = 0;
                for (i = 0; i < employeeCount; i++)
                {
                    if (childNodes[i].Employee.RoleNode.Role.ProjectLeaderRole)
                    {
                        if (childNodes[i].GetTeamCost() != 0 && childNodes[i].GetTeamCost() < Double.Parse(textbox.Text))
                        {
                            comboBox.Items.Add(childNodes[i].Employee.Name);
                        }
                    }
                    GetTeamLeader(childNodes[i], textbox, comboBox);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _dataManager.resetProjectData();
            listViewProjects.Items.Clear();
            txtConsole.Text = "List View Reset";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _dataManager.SaveProjectData();
            txtConsole.Text = "Saved Successfully";
        }
        private void loadProjectData()
        {
            _dataManager.LoadProjectData();
            listViewProjects.Items.Clear();
            listViewProjects.Items.AddRange(_dataManager.Projects.Select(p => new ListViewItem(new String[]
            {
                p.Name,
                p.UUID,
                p.Revenue.ToString(),
                p.TeamLeader.Name,
            })).ToArray());
            txtConsole.Text = "Loaded Successfully";
        }

        private void listViewProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pnlEdit.Enabled)
            {
                if (listViewProjects.SelectedItems.Count > 0)
                {
                    Project p = _dataManager.Projects[listViewProjects.SelectedIndices[0]];
                    txtUUID.Text = p.UUID;
                    txtProjectName_view.Text = p.Name;
                    txtRevenue_view.Text = p.Revenue.ToString();
                    cboTeamLeader_view.SelectedIndex = 0;
                    txtConsole.Text = "Selected Project: " + p.Name;
                } 
            }
        }
        private void txtRevenue_view_TextChanged(object sender, EventArgs e)
        {
            cboTeamLeader_view.Items.Clear();
            if (txtRevenue_view.Text != "")
            {
                GetTeamLeader(_dataManager.EmployeeTreeStructure, txtRevenue_view, cboTeamLeader_view);
            }
        }
    }
}
