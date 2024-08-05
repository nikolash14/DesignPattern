using CSharpDesignPattern.Behavioral.Strategy;

namespace CSharpDesignPattern.Behavioral.StrategyWithDependencyInjection
{
    public class SalaryCalulator
    {
        private readonly IEnumerable<StrategyWithDependencyInjection.ISalaryCalculator> _salaryCalulator;

        public SalaryCalulator(IEnumerable<ISalaryCalculator> salaryCalulator)
        {
            _salaryCalulator = salaryCalulator;
        }

        public double Calculate(IEnumerable<Employee> employees, EmployeeLevel employeeLevel) =>
            _salaryCalulator.First(m => m.Level == employeeLevel)
            .CalculateTotalSalary(employees);
    }
}
