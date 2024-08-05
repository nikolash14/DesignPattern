using CSharpDesignPattern.Behavioral.Strategy;

namespace CSharpDesignPattern.Behavioral.StrategyWithDependencyInjection
{
    public class SeniorEmployeeSalary : ISalaryCalculator
    {
        public EmployeeLevel Level => EmployeeLevel.Senior;

        public double CalculateTotalSalary(IEnumerable<Employee> employees) =>
            employees
            .Where(m => m.Level == EmployeeLevel.Senior)
            .Select(m => m.CalculateSalary() * 1.5)
            .Sum();
    }
}
