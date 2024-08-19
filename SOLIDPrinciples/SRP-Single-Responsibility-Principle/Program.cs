
using SRP_Single_Responsibility_Principle;

Console.WriteLine("SRP - Single Responsability Principle.");

Employee emplyee01 = new()
{
    Id = 1,
    Name = "Charler Henrique",
    Salary = 1320.0f
};

EmployeePrinter.PrintAllAttributes(emplyee01);
EmployeeSalaryManager.IncreaseSalary(emplyee01, 1.1f);
EmployeePrinter.PrintAllAttributes(emplyee01);
