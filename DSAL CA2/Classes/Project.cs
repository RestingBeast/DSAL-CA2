using System;
using System.Collections.Generic;
using System.Text;

namespace DSAL_CA2.Classes
{
    [Serializable]
    public class Project
    {
        private string _uuid;
        private string _name;
        private double _revenue;
        private Employee _teamLeader;
        public Project()
        {
            _uuid = General.GenerateUUID();
        }
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
        public double Revenue
        {
            get { return _revenue; }
            set { _revenue = value; }
        }
        public Employee TeamLeader
        {
            get { return _teamLeader; }
            set { _teamLeader = value; }
        }
    }
}
