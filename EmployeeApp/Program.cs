using ClassLibraryEmployee;

namespace EmployeeApp;

public class Program
{
    public static void Main()
    {
        Employee.OrganizationName = "Harsha Inc.";
        Console.WriteLine("***" + Employee.OrganizationName + "***");

        for (var i = 0; i < 10; i++)
        {
            var employeeNumber = i switch
            {
                0 => "FIRST EMPLOYEE:",
                1 => "SECOND EMPLOYEE:",
                2 => "THIRD EMPLOYEE:",
                3 => "FOURTH EMPLOYEE:",
                4 => "FIFTH EMPLOYEE:",
                5 => "SIXTH EMPLOYEE:",
                6 => "SEVENTH EMPLOYEE:",
                7 => "EIGHTH EMPLOYEE:",
                8 => "NINTH EMPLOYEE:",
                9 => "TENTH EMPLOYEE:",
                _ => "OTHER EMPLOYEE:"
            };
            Console.WriteLine(employeeNumber);

            var employee = new Employee();

            Console.Write("Employee Id: ");
            employee.EmployeeId = int.Parse(Console.ReadLine());

            Console.Write("Employee Name: ");
            employee.EmployeeName = Console.ReadLine();
            
            Console.Write("Salary per hour: ");
            employee.SalaryPerHour = double.Parse(Console.ReadLine());
            
            Console.Write("Number of working hours: ");
            employee.NoOfWorkingHours = double.Parse(Console.ReadLine());

            employee.NetSalary = employee.NoOfWorkingHours * employee.SalaryPerHour;
            
            Console.WriteLine("\nDETAILS OF " + employeeNumber);
            Console.WriteLine("Employee ID: " + employee.EmployeeId);
            Console.WriteLine("Employee Name: " + employee.EmployeeName);
            Console.WriteLine("Salary per Hour: " + employee.SalaryPerHour);
            Console.WriteLine("No. of Working Hours: " + employee.NoOfWorkingHours);
            Console.WriteLine("Net Salary: " + employee.NetSalary);
            Console.WriteLine("Type of Employee: " + Employee.TypeOfEmployee);
            Console.WriteLine("Department Name: " + employee.DepartmentName);
            
            Console.Write("Do you want to continue to next employee?");
            var choice = Console.ReadLine();
            
            if (choice is not ("yes" or "YES" or "Yes" or "y" or "Y"))
            {
                break;
            }
            
            Console.WriteLine("-----------------------------------");
        }
        
        Console.WriteLine("\nThank you.");
    }
}