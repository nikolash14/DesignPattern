using CSharpDesignPattern.Behavioral.Strategy;

namespace CSharpDesignPattern.Behavioral.StrategyWithDependencyInjection
{
    public class JuniorEmployeeSalary : ISalaryCalculator
    {
        public EmployeeLevel Level => EmployeeLevel.Junior;

        public double CalculateTotalSalary(IEnumerable<Employee> employees) =>
            employees
            .Where(m => m.Level == EmployeeLevel.Junior)
            .Select(m => m.CalculateSalary() * 0.8)
            .Sum();
    }
}
