using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAL_CA2.Classes
{
    [Serializable]
    public class Role
    {
        private string _uuid;
        private string _name;
        private Boolean _projectLeaderRole;
        private RoleTreeNode _container;
        // Constructors
        public Role()
        {

        }
        public Role(string name)
        {
            _uuid = General.GenerateUUID();
            _name = name;
        }
        // Getters - Setters
        public string UUID
        {
            get { return _uuid; }
            set { _uuid = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Boolean ProjectLeaderRole
        {
            get { return _projectLeaderRole; }
            set { _projectLeaderRole = value; }
        }
        public RoleTreeNode Container
        {
            get { return _container; }
            set { _container = value; }
        }
    }
}
