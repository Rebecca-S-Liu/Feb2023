using DapperTutorial.Core.Entities;
using DapperTutorial.Infrastructure.Repositories;

namespace DapperTutorial.Presentation.UI;

public class ManageEmployee
{
    private EmployeeRepository _employeeRepository = new EmployeeRepository();

    private void AddEmployee()
    {
        Employee employee = new Employee();
        Console.Write("Enter Id ==>");
        employee.Id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Name ==>");
        employee.EmployeeName = Console.ReadLine();
        Console.Write("Enter Age ==>");
        employee.Age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Department Id ==>");
        employee.DepartmentId = Convert.ToInt32(Console.ReadLine());
        _employeeRepository.Insert(employee);
    }

    private void PrintAllEmployee()
    {
        IEnumerable<Employee> employees = _employeeRepository.GetAll();
        foreach (var employee in employees)
        {
            //Console.WriteLine(employee.Id + "\t" + employee.EmployeeName + "\t" + employee.Age + "\t" + employee.DepartmentId);
            Console.WriteLine(employee.Id + "\t" + employee.EmployeeName + "\t" + employee.Age + "\t" + employee.Department.Id + "\t" + employee.Department.DepartmentName + "\t" + employee.Department.Location);
        }
    }
    
    public void Run()
    {
        PrintAllEmployee();
    }
}