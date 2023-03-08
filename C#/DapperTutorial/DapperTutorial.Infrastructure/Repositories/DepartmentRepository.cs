using System.Data;
using Dapper;
using DapperTutorial.Core.Entities;
using DapperTutorial.Core.Interfaces;
using DapperTutorial.Infrastructure.Data;

namespace DapperTutorial.Infrastructure.Repositories;

public class DepartmentRepository : IRepository<Department>
{
    private DbConnection _dbConnection = new DbConnection();
    public int Insert(Department obj)
    {
        IDbConnection conn = _dbConnection.GetConnection();
        return conn.Execute("INSERT INTO Department " +
                            "VALUES(@id, @departmentName, @location)", obj);
    }

    public int DeleteById(int id)
    {
        IDbConnection conn = _dbConnection.GetConnection();
        return conn.Execute("DELETE FROM Department WHERE Id = @departmentId", new {departmentId = id});
    }

    public int Update(Department obj)
    {
        IDbConnection conn = _dbConnection.GetConnection();
        return conn.Execute(
            "UPDATE Department SET DepartmentName = @departmentName, Location = @location WHERE Id = @id", obj);
    }

    public IEnumerable<Department> GetAll()
    {
        IDbConnection conn = _dbConnection.GetConnection();
        return conn.Query<Department>("SELECT Id, DepartmentName, Location FROM Department");
    }

    public Department GetById(int id)
    {
        IDbConnection conn = _dbConnection.GetConnection();
        return conn.QuerySingleOrDefault<Department>("SELECT Id, DepartmentName, Location FROM Department WHERE Id = @id", 
            new {id = id});
    }
}