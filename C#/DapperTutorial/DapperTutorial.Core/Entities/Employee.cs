namespace DapperTutorial.Core.Entities;

public class Employee
{
    public int Id { get; set; }
    public string? EmployeeName { get; set; }
    public int Age { get; set; }
    public int DepartmentId { get; set; }
    //Navigation property
    public Department? Department { get; set; }
}