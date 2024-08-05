namespace CSharpDesignPattern.Behavioral.Strategy
{
    public class JuniorEmployeeSalary : ISalaryCalculator
    {
        public double CalculateTotalSalary(IEnumerable<Employee> employees) =>
            employees
            .Where(m => m.Level == EmployeeLevel.Junior)
            .Select(m => m.CalculateSalary())
            .Sum();
    }
}
