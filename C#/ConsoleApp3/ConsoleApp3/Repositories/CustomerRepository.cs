using ConsoleApp3.DataModel;

namespace ConsoleApp3.Repositories;

public class CustomerRepository : IRepository<Customer>
{
    private List<Customer> customers = new List<Customer>();
    public int Insert(Customer obj)
    {
        if (GetById(obj.Id) == null)
        {
            customers.Add(obj);
            return 1;
        }
        return 0;
    }

    public int Update(Customer obj)
    {
        Customer c = GetById(obj.Id);
        if (c != null)
        {
            c.Id = obj.Id;
            c.Email = obj.Email;
            c.Name = obj.Name;
            return 1;
        }

        return 0;
    }

    public int Delete(int id)
    {
        Customer c = GetById(id);
        if (c != null)
        {
            customers.Remove(c);
            return 1;
        }

        return 0;
    }

    public List<Customer> GetAll()
    {
        return customers;
    }

    public Customer GetById(int id)
    {
        for (int i = 0; i < customers.Count; i++)
        {
            if (customers[i].Id == id)
            {
                return customers[i];
            }
        }
        return null;
    }
}