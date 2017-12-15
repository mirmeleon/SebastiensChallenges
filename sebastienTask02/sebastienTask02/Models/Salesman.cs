namespace sebastienTask02
{
   public class Salesman : Employee
    {
        public Salesman(string name, string department) : base(name, department)
        {
        }

        public override decimal ReceiveSalary(decimal salary)
        {
            decimal salaryWithBonus = (salary * 0.1m) + salary;
            return base.ReceiveSalary(salaryWithBonus);
        }
    }
}
