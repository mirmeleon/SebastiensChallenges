namespace InterfTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Company :ICompany
    {
        private IList<IEmployee> employees;

        public Company()
        {
            this.Employees = new List<IEmployee>();
        }

        public IList<IEmployee> Employees
        {
            get { return this.employees; }
            private set { this.employees = value; }
        }

        public virtual void PaySalary(int months, decimal salaryAmount)
        {
            
            int count = 0;
            while (count != months)
            {
                this.Employees
                              .ToList()
                              .ForEach(e => e.GetSalary(salaryAmount));
                count++;
            }
        }

        public virtual void SeeEmployees()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            this.Employees
                          .ToList()
                          .ForEach(e => Console.WriteLine($"Name: {e.Name} ->Salary: {e.TotalSalary:f2} "));

            Console.ReadLine();
        }
    }
}
