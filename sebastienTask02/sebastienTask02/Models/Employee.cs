namespace sebastienTask02
{
   public class Employee
    {
        private string employeeName;
        private decimal salary;
        private string department;
        
        public Employee(string name, string department)
        {
            this.EmployeeName = name;
            this.Department = department;
        }

        public string EmployeeName
        {
            get { return this.employeeName; }
            private set { this.employeeName = value; }
        }

        public decimal Salary
        {
            get { return this.salary; }
           private set { this.salary = value; }
        }

        public string Department
        {
            get { return this.department; }
            private set { this.department = value; }
        }

        public virtual decimal ReceiveSalary(decimal salary)
        {
           return this.Salary += salary;
        }
        
    }
}
