namespace InterfTest
{
   public class Seller : Employee
    {
        public Seller(string name) : base(name)
        {
        }

        public override void GetSalary(decimal salary)
        {
            decimal bonusAndSalary = (salary * 0.2m) + salary;
            this.TotalSalary += bonusAndSalary;
        }
    }
}
