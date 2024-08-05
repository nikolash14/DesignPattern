namespace CSharpDesignPattern.Behavioral.Strategy
{
    public interface ISalaryCalculator
    {
        double CalculateTotalSalary(IEnumerable<Employee> employees); 
    }
}
