namespace ConsoleApp2;

public class Customer
{
    //public string customerName;
    //full version of property: private data field + get and set methods
    // private string customerName;
    //
    // public string CustomerName
    // {
    //     get
    //     {
    //         return customerName;
    //     }
    //     set
    //     {
    //         customerName = value;
    //     }
    // }

    //auto-generated filed
    public string CustomerName;

    private int id;

    public int Id
    {
        get
        {
            return id;
        }
        private set
        {
            id = value;
        }
    }
    
    //public int id;
    //private int id;
    
    public string Email { get; set; }
    public string Phone { get; set; }

    public Customer(int id, string customerName, string email)
    {
        Id = id;
        CustomerName = customerName;
        Email = email;
    }
    public Customer(int id, string customerName, string email, string phone)
         {
             Id = id;
             CustomerName = customerName;
             Email = email;
             Phone = phone;
         }
}