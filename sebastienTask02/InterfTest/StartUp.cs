namespace InterfTest
{
    using System;
    public class StartUp
    {
       public static void Main()
        {
            ICompany sqli = new Company();
            IEmployee maria = new Secretary("Maria");
            IEmployee pesho = new Seller("Pesho");

            sqli.Employees.Add(maria);
            sqli.Employees.Add(pesho);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Sebastien, please, enter for how many months do you want to pay salary to your employees");
            int monts = 0; 
            bool montsCorrect = int.TryParse(Console.ReadLine(), out monts);

            while(!montsCorrect)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hm.., don't mess with my program!");
                montsCorrect = int.TryParse(Console.ReadLine(), out monts);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Salary amount?");

            decimal salary = 0;
            bool salaryCorrect = decimal.TryParse(Console.ReadLine(), out salary);

            if(montsCorrect && salaryCorrect)
            {
                sqli.PaySalary(monts, salary);
                sqli.SeeEmployees();
            }
       

        }
    }
}
