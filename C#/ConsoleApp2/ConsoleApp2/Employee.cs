using System.Security.Cryptography;

namespace ConsoleApp2;

public abstract class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }

    public abstract void PerformWork();

    public virtual void VirtualMethodDemo()
    {
        Console.WriteLine("This is a virtual method from base class");
    }

    public Employee(int id)
    {
        Id = id;
    }
}

public class FullTimeEmployee : Employee
{
    public decimal BiweeklyPay { get; set; }
    public string Benefits { get; set; }

    public override void PerformWork()
    {
        Console.WriteLine("Full time employees work 40 hrs a week");
    }

    public override void VirtualMethodDemo()
    {
        //base.VirtualMethodDemo();
        Console.WriteLine("override in full time employee class");
    }

    public FullTimeEmployee(int id, decimal biweeklyPay) : base(id)
    {
        BiweeklyPay = biweeklyPay;
    }
}

public sealed class PartTimeEmployee : Employee
{
    public decimal HourlyPay { get; set; }
    public override void PerformWork()
    {
        Console.WriteLine("Part time employees work 20 hrs a week");
    }

    public PartTimeEmployee(int id) : base(id)
    {
        
    }

    static void TestDemo()
    {
        
    }
}

// public class Test : PartTimeEmployee
// {
//     
// }

public class Manager : FullTimeEmployee
{
    public decimal ExtraBonus { get; set; }

    public void AttendMeeting()
    {
        Console.WriteLine("Managers have to attend meetings");
    }

    public Manager(int id, decimal biweeklyPay) : base(id, biweeklyPay)
    {
        
    }
}
