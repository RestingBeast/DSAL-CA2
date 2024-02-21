using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;


namespace DSAL_CA2.Classes
{
    [Serializable]
    public class DataManager
    {
        RoleTreeNode _roleTreeStructure = new RoleTreeNode();
        EmployeeTreeNode _employeeTreeStructure = new EmployeeTreeNode();
        List<Project> _projects = new List<Project>();

        // Saved data file path
        private string _filePathRole;
        private string _filePathEmployee;
        private string _filePathProjects;

        // Getters - Setters
        public RoleTreeNode RoleTreeStructure
        {
            get { return _roleTreeStructure; }
            set { _roleTreeStructure = value; }
        }
        public EmployeeTreeNode EmployeeTreeStructure
        {
            get { return _employeeTreeStructure; }
            set { _employeeTreeStructure = value; }
        }
        public List<Project> Projects
        {
            get { return _projects; }
            set { _projects = value; }
        }
        public DataManager()
        {
            _filePathRole = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\RoleData.dat";
            _filePathEmployee = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\EmployeeData.dat";
            _filePathProjects = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\ProjectsData.dat";
            LoadRoleData();
            LoadEmployeeData();
        }
        public void resetRoleData()
        {
            _roleTreeStructure = new RoleTreeNode(new Role("Root"));
        }
        public void resetEmployeeData()
        {
            _employeeTreeStructure = new EmployeeTreeNode(new Employee("Root"),_roleTreeStructure);
        }
        public void resetProjectData()
        {
            _projects = new List<Project>();
        }
        public void SaveRoleData()
        {
            this.RoleTreeStructure.SaveToFileBinary(_filePathRole);
        }

        public RoleTreeNode LoadRoleData()
        {
            this.RoleTreeStructure = this.RoleTreeStructure.ReadFromFileBinary(_filePathRole);
            this.RoleTreeStructure.RebuildTreeNodes();
            return this.RoleTreeStructure;
        }

        public void SaveEmployeeData()
        {
            this.EmployeeTreeStructure.SaveToFileBinary(_filePathEmployee);
        }

        public EmployeeTreeNode LoadEmployeeData()
        {
            this.EmployeeTreeStructure = this.EmployeeTreeStructure.ReadFromFileBinary(_filePathEmployee);
            this.EmployeeTreeStructure.RebuildTreeNodes();
            return this.EmployeeTreeStructure;
        }
        public void DeleteRoleNode(RoleTreeNode role)
        {
            _roleTreeStructure.Nodes.Remove(role);
            role.ParentNode.ChildNodes.Remove(role);
        }
        public void DeleteEmployeeNode(EmployeeTreeNode employee)
        {
            _employeeTreeStructure.Nodes.Remove(employee);
            employee.ParentNode.ChildNodes.Remove(employee);
        }
        public void SaveProjectData()
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                Stream stream = new FileStream( _filePathProjects, FileMode.OpenOrCreate, FileAccess.Write);

                bf.Serialize(stream, this.Projects);
                stream.Close();

                MessageBox.Show("Data is added to file");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadProjectData()
        {
            try
            {
                Stream stream = new FileStream(_filePathProjects, FileMode.OpenOrCreate, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                if (stream.Length != 0)
                {
                    _projects = (List<Project>)bf.Deserialize(stream);
                }
                stream.Close();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Unable to find file.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
