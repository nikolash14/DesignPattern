using CSharpDesignPattern.Behavioral.Strategy;
using Microsoft.Extensions.DependencyInjection;

namespace CSharpDesignPattern.Behavioral.StrategyWithDependencyInjection.Handler
{
    public class HandleStrategyWithDependencyInjection
    {
        public static void Run()
        {
            var serviceProvider = ServiceProvider.CreateServices();
            var salaryContext = serviceProvider.GetService<SalaryCalulator>();
            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Nikolash", Level = EmployeeLevel.Senior, HourlyRate = 25, WorkingHours =8},
                new Employee { Id = 2, Name = "Prince", Level = EmployeeLevel.Junior, HourlyRate = 20, WorkingHours =8},
                new Employee { Id = 3, Name = "Rakesh", Level = EmployeeLevel.Senior, HourlyRate = 25, WorkingHours =8},
                new Employee { Id = 4, Name = "Ritika", Level = EmployeeLevel.Junior, HourlyRate = 20, WorkingHours =8},
                new Employee { Id = 5, Name = "Monalisa", Level = EmployeeLevel.Senior, HourlyRate = 25, WorkingHours =4}
            };
            Console.WriteLine("\nStrategy With Dependency Injection");
            Console.WriteLine("Total Junior Salary - " + salaryContext.Calculate(employees, EmployeeLevel.Junior));
            Console.WriteLine("Total Senior Salary - " + salaryContext.Calculate(employees, EmployeeLevel.Senior));
            Console.WriteLine("\n");
        }
    }
}
