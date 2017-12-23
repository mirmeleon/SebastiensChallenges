namespace InterfTest
{
  public class Employee : IEmployee
    {
        private string name;
        private decimal totalSalary;

        public Employee(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public decimal TotalSalary
        {
            get { return this.totalSalary; }
            protected set
            {
                this.totalSalary = value;
            }
        }
        public virtual void GetSalary(decimal salary)
        {
            this.TotalSalary += salary;
        }
    }
}
