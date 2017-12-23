namespace InterfTest
{
    using System.Collections.Generic;
    public interface ICompany
    {
        IList<IEmployee> Employees { get; }

        void PaySalary(int months, decimal salaryAmount);

        void SeeEmployees();
    }
}
