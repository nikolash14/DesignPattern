using CSharpDesignPattern.Behavioral.Strategy;

var employees = new List<Employee>
{

    new Employee { Id = 1, Name = "Nikolash", Level = EmployeeLevel.Senior, HourlyRate = 25, WorkingHours =8},
    new Employee { Id = 2, Name = "Prince", Level = EmployeeLevel.Junior, HourlyRate = 20, WorkingHours =8},
    new Employee { Id = 3, Name = "Rakesh", Level = EmployeeLevel.Senior, HourlyRate = 25, WorkingHours =8},
    new Employee { Id = 4, Name = "Ritika", Level = EmployeeLevel.Junior, HourlyRate = 20, WorkingHours =8},
    new Employee { Id = 5, Name = "Monalisa", Level = EmployeeLevel.Senior, HourlyRate = 25, WorkingHours =4}
};

var caculateSalary = new SalaryCalculator(new JuniorEmployeeSalary());
Console.WriteLine("Total Junior Salary - " + caculateSalary.Calculate(employees));

caculateSalary.SetCalculator(new SeniorEmployeeSalary());
Console.WriteLine("Total Senior Salary - " + caculateSalary.Calculate(employees));


Console.ReadLine();