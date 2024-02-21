using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAL_CA2.Classes
{
    [Serializable]
    public class Employee
    {
        private string _uuid;
        private string _name;
        private EmployeeTreeNode _reportingOfficer;
        private double _salary;
        private RoleTreeNode _roleNode;
        private EmployeeTreeNode _container;
        private bool _dummyData = false;
        private bool _salaryAccountable = true;
        public Employee()
        {
            
        }
        public Employee(string name)
        {
            this._name = name;
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
        public EmployeeTreeNode ReportingOfficer
        {
            get { return _reportingOfficer; }
            set { _reportingOfficer = value; }
        }
        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public RoleTreeNode RoleNode
        {
            get { return _roleNode; }
            set { _roleNode = value; }
        }
        public EmployeeTreeNode Container
        {
            get { return _container; }
            set { _container = value; }
        }
        public bool DummyData
        {
            get { return _dummyData; }
            set { _dummyData = value; }
        }
        public bool SalaryAccountable
        {
            get { return _salaryAccountable; }
            set { _salaryAccountable = value; }
        }
    }
}
