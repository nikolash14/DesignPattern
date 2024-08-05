namespace CSharpDesignPattern.Behavioral.Strategy
{
    public class SeniorEmployeeSalary : ISalaryCalculator
    {
        public double CalculateTotalSalary(IEnumerable<Employee> employees) =>
            employees
            .Where(m => m.Level == EmployeeLevel.Senior)
            .Select(m => m.CalculateSalary() * 1.2)
            .Sum();
    }
}
