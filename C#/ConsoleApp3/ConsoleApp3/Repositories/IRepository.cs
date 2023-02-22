namespace ConsoleApp3.Repositories;

public interface IRepository<T> where T : class
{
    int Insert(T obj);
    int Update(T obj);
    int Delete(int id);
    List<T> GetAll();
    T GetById(int id);
}