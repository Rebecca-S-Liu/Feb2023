using System.Data;
using Dapper;
using DapperTutorial.Core.Entities;
using DapperTutorial.Core.Interfaces;
using DapperTutorial.Infrastructure.Data;

namespace DapperTutorial.Infrastructure.Repositories;

public class EmployeeRepository : IRepository<Employee>
{
    private DbConnection _dbConnection = new DbConnection();
    public int Insert(Employee obj)
    {
        IDbConnection conn = _dbConnection.GetConnection();
        return conn.Execute("INSERT INTO Employee " +
                            "VALUES(@id, @employeeName, @age, @departmentId)", obj);
    }

    public int DeleteById(int id)
    {
        throw new NotImplementedException();
    }

    public int Update(Employee obj)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Employee> GetAll()
    {
        IDbConnection conn = _dbConnection.GetConnection();
        var sql = "SELECT e.id, e.employeename, e.age, e.departmentid, d.id, d.departmentname, d.location " +
                  "FROM Employee e INNER JOIN Department d on e.DepartmentId = d.Id";
        return conn.Query<Employee, Department, Employee>(sql, 
            ((employee, department) => { 
                employee.Department = department;
                return employee;
            }));
    }

    public Employee GetById(int id)
    {
        throw new NotImplementedException();
    }
}