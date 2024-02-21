using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSAL_CA2.Classes
{
    [Serializable]
    public class EmployeeTreeNode :TreeNode, ISerializable
    {
        private EmployeeTreeNode _parentNode;
        private Employee _employee;
        private List<EmployeeTreeNode> _children;
        public EmployeeTreeNode ParentNode
        {
            get { return _parentNode; }
            set { _parentNode = value; }
        }
        public Employee Employee
        {
            get { return _employee; }
            set { _employee = value; }
        }
        public List<EmployeeTreeNode> ChildNodes
        {
            get { return _children; }
            set { _children = value; }
        }
        public EmployeeTreeNode()
        {

        }
        public EmployeeTreeNode(Employee employee, RoleTreeNode roleNode)
        {
            _parentNode = null;
            _children = new List<EmployeeTreeNode>();
            _employee = employee;
            employee.RoleNode = roleNode;
            _employee.Container = this;
            this.Text = employee.Name + "-" + employee.RoleNode.Role.Name + "(S$" + employee.Salary + ")";
        }
        public void AddChildEmployeeTreeNode(EmployeeTreeNode employeeNode)
        {
            employeeNode.ParentNode = this;
            _children.Add(employeeNode);
            this.Nodes.Add(employeeNode);
        }
        public void RebuildTreeNodes()
        {
            this.Text = this.Employee.Name + "-" + this.Employee.RoleNode.Role.Name + "(S$" + this.Employee.Salary + ")";
            if (this.ChildNodes.Count > 0)
            {
                int i = 0;
                for (i = 0; i < this.ChildNodes.Count; i++)
                {
                    this.Nodes.Add(this.ChildNodes[i]);
                    this.ChildNodes[i].ParentNode = this;
                    this.ChildNodes[i].RebuildTreeNodes();
                }
            }

        }
        // Save and Load Functions
        public void SaveToFileBinary(string filepath)
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                Stream stream = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);

                bf.Serialize(stream, this);
                stream.Close();

                MessageBox.Show("Data is added to file");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public EmployeeTreeNode ReadFromFileBinary(string filepath)
        {
            try
            {
                Stream stream = new FileStream(@filepath, FileMode.OpenOrCreate, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                EmployeeTreeNode root = null;
                if (stream.Length != 0)
                {
                    root = (EmployeeTreeNode)bf.Deserialize(stream);
                }
                stream.Close();

                return root;
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Unable to find file.");
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Employee", _employee);
            info.AddValue("ChildrenEmployeeTreeNodes", _children);
            info.AddValue("ParentEmployeeTreeNode", _parentNode);

        }
        protected EmployeeTreeNode(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new System.ArgumentNullException("info");
            this.Employee = (Employee)info.GetValue("Employee", typeof(Employee));
            this.Employee.Container = this;
            this.ChildNodes = (List<EmployeeTreeNode>)info.GetValue("ChildrenEmployeeTreeNodes", typeof(List<EmployeeTreeNode>));
            this.ParentNode = (EmployeeTreeNode)info.GetValue("ParentEmployeeTreeNode", typeof(EmployeeTreeNode));
        }
        public void SearchByUUID(string uuid, ref List<EmployeeTreeNode> foundNodes)
        {
            if (this.ChildNodes.Count > 0)
            {
                int i = 0;
                for (i = 0; i < this.ChildNodes.Count; i++)
                {
                    if (this.ChildNodes[i].Employee.UUID == uuid)
                    {  
                        foundNodes.Add(this.ChildNodes[i]);
                    }
                    else
                    {
                        this.ChildNodes[i].SearchByUUID(uuid, ref foundNodes);
                    }
                }
            }
        }
        public double GetTeamCost()
        {
            double cost = 0;
            if (this.Employee.RoleNode.Role.ProjectLeaderRole)
            {
                cost += this.Employee.Salary;
                int i = 0;
                for (i = 0; i < this.ChildNodes.Count; i++)
                {
                    cost += this.ChildNodes[i].Employee.Salary;
                }
            }
            return cost;
        }
        public void SearchByName(string name, ref EmployeeTreeNode foundNode)
        {
            if (this.ChildNodes.Count > 0)
            {
                int i = 0;
                for (i = 0; i < this.ChildNodes.Count; i++)
                {
                    if (this.ChildNodes[i].Employee.Name == name)
                    {
                        foundNode = this.ChildNodes[i];
                    }
                    else
                    {
                        this.ChildNodes[i].SearchByName(name, ref foundNode);
                    }
                }
            }
        }
        public void SearchByRole(RoleTreeNode role, ref List<EmployeeTreeNode> foundNodes)
        {
            if (this.ChildNodes.Count > 0)
            {
                int i = 0;
                for (i = 0; i < this.ChildNodes.Count; i++)
                {
                    if (this.ChildNodes[i].Employee.RoleNode.Role.Name == role.Role.Name)
                    {
                        foundNodes.Add(this.ChildNodes[i]);
                    }
                    else
                    {
                        this.ChildNodes[i].SearchByRole(role, ref foundNodes);
                    }
                }
            }
        }
    }
}
