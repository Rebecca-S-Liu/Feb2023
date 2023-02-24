using ConsoleApp5.DataModels;
using ConsoleApp5.Repositories;

namespace ConsoleApp5.Presentation;

public class ManageEmployee
{
    private EmployeeRepository _employeeRepository = new EmployeeRepository();

    private Employee Demo(Employee employee)
    {
        return employee;
    }
    private void SelectDemo()
    {
        //SELECT * FROM Employees
        //Query syntax
        // var result = (from employee in _employeeRepository.GetEmployees()
        //     select employee);
        //Method syntax
        // var result = _employeeRepository.GetEmployees().Select(employee => employee);
        // foreach (var employee in result)
        // {
        //     Console.WriteLine(employee.Id + "\t" + employee.FullName + "\t" + employee.Salary + "\t" + employee.Department + "\t" + employee.Age);
        // }
        
        //query syntax
        // var result = from employee in _employeeRepository.GetEmployees()
        //     select employee.FullName;
        //method syntax
        // var result = _employeeRepository.GetEmployees().Select(employee => employee.FullName);
        // foreach (var name in result)
        // {
        //     Console.WriteLine(name);
        // }
        
        //query syntax
        // var result = from employee in _employeeRepository.GetEmployees()
        //     select new
        //     {
        //         Id = employee.Id,
        //         FullName = employee.FullName,
        //         Department = employee.Department
        //     };
        //method syntax
        // var result = _employeeRepository.GetEmployees().Select(employee =>
        //     new { Id = employee.Id, FullName = employee.FullName, Department = employee.Department });
        // foreach (var employee in result)
        // {
        //     Console.WriteLine(employee.Id + "\t" + employee.FullName + "\t" + employee.Department);
        // }
        
        //Distinct()
        // var result = (from employee in _employeeRepository.GetEmployees()
        //     select employee.Department).Distinct();
        // var result = _employeeRepository.GetEmployees().Select(employee => employee.Department).Distinct();
        // foreach (var Department in result)
        // {
        //     Console.WriteLine(Department);   
        // }

        var result = _employeeRepository.GetEmployees().Select(employee => new
        {
            Id = employee.Id,
            FullName = employee.FullName,
            Department = employee.Department
        }).SingleOrDefault(x => x.Department == "sdgsodiug");
        //Console.WriteLine(result.Id + "\t" + result.FullName + "\t" + result.Department);
    }

    public void OrderByDemo()
    {
        //query syntax
        // var result = from employee in _employeeRepository.GetEmployees()
        //     orderby employee.Salary descending, employee.FullName descending 
        //     select new
        //     {
        //         Id = employee.Id,
        //         FullName = employee.FullName,
        //         Salary = employee.Salary
        //     };
        
        //method syntax
        var result = _employeeRepository.GetEmployees().OrderByDescending(employee => employee.Salary).ThenByDescending(employee => employee.FullName).Select(employee => new
        {
            Id = employee.Id,
            FullName = employee.FullName,
            Salary = employee.Salary
        });
        foreach (var employee in result)
        {
            Console.WriteLine(employee.Id + "\t" + employee.FullName + "\t" + employee.Salary);
        }
    }

    public void WhereDemo()
    {
        //query syntax
        // var result = from employee in _employeeRepository.GetEmployees()
        //     where employee.Salary > 7000
        //         select new
        //         {
        //             Id = employee.Id,
        //             FullName = employee.FullName,
        //             Salary = employee.Salary
        //         };

        //method syntax
        var result = _employeeRepository.GetEmployees().Where(employee => employee.Salary > 7000).Select(employee => new
        {
            Id = employee.Id,
            FullName = employee.FullName,
            Salary = employee.Salary
        });
        foreach (var employee in result)
        {
            Console.WriteLine(employee.Id + "\t" + employee.FullName + "\t" + employee.Salary);
        }
    }

    public void QuantifierDemo()
    {
        var result = _employeeRepository.GetEmployees().Any(employee => employee.Salary >= 10000);
        Console.WriteLine(result);
        
    }

    public void GroupByDemo()
    {
        //query syntax
        // var result = from employee in _employeeRepository.GetEmployees()
        //     group employee by employee.Department;
        
        //method syntax
        var result = _employeeRepository.GetEmployees().GroupBy(employee => employee.Department);
        foreach (var group in result)
        {
            Console.WriteLine($"{group.Key} Department");
            foreach (var employee in group)
            {
                Console.WriteLine($"Employee : {employee.FullName}");
            }
            Console.WriteLine();
        }
    }

    public void AggregationsDemo()
    {
        // var result = _employeeRepository.GetEmployees().Average(x => x.Salary);
        // Console.WriteLine(result);
        var result = _employeeRepository.GetEmployees().GroupBy(employee => employee.Department).Select(x => new
        {
            Department = x.Key,
            TotalSalary = x.Sum(employee => employee.Salary),
            AverageSalary = Math.Round(x.Average(employee => employee.Salary), 2)
        });
        foreach (var departmentGroup in result)
        {
            Console.WriteLine(departmentGroup.Department + "\t" + departmentGroup.TotalSalary + "\t" + departmentGroup.AverageSalary);
        }
    }
    
    public void Run()
    {
        AggregationsDemo();
    }
}