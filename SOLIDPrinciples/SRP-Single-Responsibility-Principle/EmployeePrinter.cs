namespace SRP_Single_Responsibility_Principle
{
    public class EmployeePrinter
    {
        public static void PrintAllAttributes(Employee employee)
        {
            Console.WriteLine($"Id: {employee.Id} | Name: {employee.Name} | Salary: {employee.Salary}");
        }
    }
}
