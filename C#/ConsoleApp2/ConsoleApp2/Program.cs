// See https://aka.ms/new-console-template for more information

using ConsoleApp2;
// Customer c = new Customer();
// c.CustomerName = "Smith";
// Console.WriteLine(c.CustomerName);

// Customer firstCustomer = new Customer(1, "Smith", "123@abc.com");
// Console.WriteLine($"The id for the first customer is {firstCustomer.Id}");
//
// Customer secondCustomer = new Customer(2, "Laura", "456@abc.com", "0123456789");
// Console.WriteLine($"The phone number for {secondCustomer.CustomerName} is {secondCustomer.Phone}");

// FullTimeEmployee fullTimeEmployee = new FullTimeEmployee(1, 1000);
// fullTimeEmployee.VirtualMethodDemo();
// PartTimeEmployee pte = new PartTimeEmployee(1);
// pte.VirtualMethodDemo();
//
// //Employee employee = new Employee();
//
// //Addition addition = new Addition();
// Addition.AddNumbers(1,2,1);
//
// int a = 3;
// Console.WriteLine(a.EvenOrOdd());

EmployeeRepository employeeRepository = new EmployeeRepository();
employeeRepository.CreateEmployee(new FullTimeEmployee(1, 100));
employeeRepository.CreateEmployee(new Manager(2, 100));
employeeRepository.CreateEmployee(new PartTimeEmployee(1));

List<Employee> employees = employeeRepository.GetAllEmployees();
foreach(var employee in employees) {
    Console.WriteLine(employee.Id);
}


Dictionary<int, string> dict = new Dictionary<int, string>();