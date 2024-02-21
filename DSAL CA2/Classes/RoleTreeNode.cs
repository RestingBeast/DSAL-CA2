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
    public class RoleTreeNode:TreeNode, ISerializable
    {
        private RoleTreeNode _parentNode;
        private Role _role;
        private List<RoleTreeNode> _children;

        // Getters - Setters
        public RoleTreeNode ParentNode
        {
            get { return _parentNode; }
            set { _parentNode = value; }
        }
        public Role Role
        {
            get { return _role; }
            set { _role = value; }
        }
        public List<RoleTreeNode> ChildNodes
        {
            get { return _children; }
            set { _children = value; }
        }
        // Constructors
        public RoleTreeNode(Role role)
        {
            _parentNode = null;
            _children = new List<RoleTreeNode>();
            _role = role;
            _role.Container = this;
            this.Text = role.Name;
        }
        public RoleTreeNode()
        {

        }

        // Functions
        public void AddChildRoleTreeNode(RoleTreeNode roleNode)
        {
            roleNode.ParentNode = this;
            _children.Add(roleNode);
            this.Nodes.Add(roleNode);
        }

        public void RebuildTreeNodes()
        {
            this.Text = this.Role.Name;
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

        public RoleTreeNode ReadFromFileBinary(string filepath)
        {
            try
            {
                Stream stream = new FileStream(@filepath, FileMode.OpenOrCreate, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                RoleTreeNode root = null;
                if (stream.Length != 0)
                {
                    root = (RoleTreeNode)bf.Deserialize(stream);
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
            info.AddValue("Role", _role);
            info.AddValue("ChildrenRoleTreeNodes", _children);
            info.AddValue("ParentRoleTreeNode", _parentNode);

        }
        protected RoleTreeNode(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new System.ArgumentNullException("info");
            this.Role = (Role)info.GetValue("Role", typeof(Role));
            this.Role.Container = this;
            this.ChildNodes = (List<RoleTreeNode>)info.GetValue("ChildrenRoleTreeNodes", typeof(List<RoleTreeNode>));
            this.ParentNode = (RoleTreeNode)info.GetValue("ParentRoleTreeNode", typeof(RoleTreeNode));
        }
        public void SearchByUUID(string uuid, ref List<RoleTreeNode> foundNodes)
        {
            if (this.ChildNodes.Count > 0)
            {
                int i = 0;
                for (i = 0; i < this.ChildNodes.Count; i++)
                {
                    if (this.ChildNodes[i].Role.UUID == uuid)
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
    }
}
