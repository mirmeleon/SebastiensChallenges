
using System.Collections.Generic;

namespace sebastienTask02
{
    public class Company
    {
        private string companyName;
        private IList<Employee> employees;

        public Company(string companyName)
        {
            this.CompanyName = companyName;
            this.Employees = new List<Employee>();
        }

        public string CompanyName
        {
            get { return this.companyName; }
            private set { this.companyName = value; }
        }

        public IList<Employee> Employees
        {
            get { return this.employees; }
            set { this.employees = value; }
        }

        public int GetEmployeesNumber()
        {
            return this.Employees.Count;
        }

        public IList<Employee> AddEmployee(Employee employee)
        {
            this.Employees.Add(employee);
            return Employees;
        }
      
    }
}
