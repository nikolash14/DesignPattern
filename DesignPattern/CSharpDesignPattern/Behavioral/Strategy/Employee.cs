namespace CSharpDesignPattern.Behavioral.Strategy
{
    public enum EmployeeLevel
    {
        Senior = 1,
        Junior = 2
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EmployeeLevel Level { get; set; }
        public int WorkingHours { get; set; }
        public float HourlyRate { get; set; }

        public double CalculateSalary() => HourlyRate * WorkingHours;
    }
}
