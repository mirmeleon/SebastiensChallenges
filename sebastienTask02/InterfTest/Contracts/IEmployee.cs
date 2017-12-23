namespace InterfTest
{
   public interface IEmployee
    {
        string Name { get; }

        decimal TotalSalary { get; }

        void GetSalary(decimal salary);
    }
}
