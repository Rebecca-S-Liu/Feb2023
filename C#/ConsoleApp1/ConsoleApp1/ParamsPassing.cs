namespace ConsoleApp1;

public class ParamsPassing
{
    
    public void PassingByValue(int a, int b, string str)
    {
        a = 80;
        b = 20;
        str = "World";
        Console.WriteLine($"Inside passing by value method: a = {a}, b = {b}, str = {str}");
    }
    
    public void PassingByReference(ref int a, ref int b, ref string str)
    {
        a = 80;
        b = 20;
        str = "World";
        Console.WriteLine($"Inside passing by value method: a = {a}, b = {b}, str = {str}");
    }

    public void AreaOfCircle(double radius, double pi = 3.14)
    {
        Console.WriteLine($"The Area of Circle is {pi * radius * radius}");
    }

    public bool IsAuthentic(string uname, string password, out string msg)
    {
        msg = "";
        if (uname == "Rebecca" && password == "Antra123")
        {
            msg = "You have been verified";
            return true;
        }
        else
        {
            msg = "Invalid cridentials";
            return false;
        }
        
    }

    [Obsolete]
    public int AddTwoNumbers(int a, int b)
    {
        return a + b;
    }

    [Obsolete("Use AddNumbers(params int[]arr instead)", true)]
    public int AddThreeNumbers(int a, int b, int c)
    {
        return a + b + c;
    }

    public int AddNumbers(params int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum = sum + arr[i];
        }

        return sum;
    }
    
}