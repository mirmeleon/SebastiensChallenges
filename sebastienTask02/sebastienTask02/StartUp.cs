using System;
using System.Collections.Generic;
using System.Linq;

namespace sebastienTask02
{
  public class StartUp
    {
      public static void Main()
        {
            Console.WriteLine("Please, enter your company name: ");
            Company company = new Company(Console.ReadLine().ToUpper());

            Console.WriteLine("First Employee name:");
            string name = Console.ReadLine();
            string department = "Sales";
            
            Employee pesho = new Salesman(name, department);
            Console.WriteLine("For the purpouse of this program we will use the same salary for both employees. Please enter salary :)");
            decimal salary = Decimal.Parse(Console.ReadLine());
            pesho.ReceiveSalary(salary);

            Console.WriteLine("Second Employee name:");
            name = Console.ReadLine();

            Employee antonina = new Secretary(name, "Administration");
            antonina.ReceiveSalary(salary);
            company.AddEmployee(pesho);
            company.AddEmployee(antonina);
           
            company.Employees
                .ToList()
                .ForEach(e => Console.WriteLine($"Name: {e.EmployeeName}; Department: {e.Department}; Salary: {e.Salary:f2} "));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*------SECOND MONTH-------*");
            Console.ForegroundColor = ConsoleColor.White;
            pesho.ReceiveSalary(salary);
            antonina.ReceiveSalary(salary);

            company.Employees
                .ToList()
                .ForEach(e => Console.WriteLine($"Name: {e.EmployeeName}; Department: {e.Department}; Salary: {e.Salary:f2}"));

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Company name: {company.CompanyName}; Total employees:{company.GetEmployeesNumber()} ");
            Console.ReadLine();
        }
    }
}
