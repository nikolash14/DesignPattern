namespace CSharpDesignPattern.Behavioral.Strategy
{
    public class SalaryCalculator
    {
        private ISalaryCalculator _calculator;

        public SalaryCalculator(ISalaryCalculator calculator)
        {
            _calculator = calculator;
        }

        public void SetCalculator(ISalaryCalculator calculator) => _calculator = calculator;

        public double Calculate(IEnumerable<Employee> employees) =>
            _calculator.CalculateTotalSalary(employees);
    }
}
