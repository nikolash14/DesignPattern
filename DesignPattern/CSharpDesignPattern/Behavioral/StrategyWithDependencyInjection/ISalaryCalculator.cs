
using CSharpDesignPattern.Behavioral.Strategy;

namespace CSharpDesignPattern.Behavioral.StrategyWithDependencyInjection
{
    public interface ISalaryCalculator
    {
        EmployeeLevel Level { get; }
        double CalculateTotalSalary(IEnumerable<Employee> employees);
    }
}
