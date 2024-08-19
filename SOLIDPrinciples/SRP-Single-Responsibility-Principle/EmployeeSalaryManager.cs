namespace SRP_Single_Responsibility_Principle
{
    public class EmployeeSalaryManager
    {
        public static void IncreaseSalary(Employee employee, float percentage)
        {
            employee.Salary *= percentage;
        }
    }
}
