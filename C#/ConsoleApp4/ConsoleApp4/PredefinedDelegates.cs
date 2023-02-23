namespace ConsoleApp4;

public class PredefinedDelegates
{
    //Fibonacci sequence: 0, 1, 1, 2, 3, 5...
    private void Fibonacci(int length)
    {
        int a = 0, b = 1, c = 0;
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(a + " ");
            c = a + b;
            a = b;
            b = c;
        }
    }

    public void ActionExample()
    {
        //Action<int> fib = new Action<int>(Fibonacci);
        //Anonymous method
        // Action<int> fib = delegate(int length)
        // {
        //     int a = 0, b = 1, c = 0;
        //     for (int i = 0; i < length; i++)
        //     {
        //         Console.WriteLine(a + " ");
        //         c = a + b;
        //         a = b;
        //         b = c;
        //     }
        // };
        //Lambda expression
        //Lambda operator in C# =>
        Action<int> fib = length =>
        {
            int a = 0, b = 1, c = 0;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(a + " ");
                c = a + b;
                a = b;
                b = c;
            }
        };
        fib(10);
    }

    public void PredicateDemo()
    {
        Predicate<string> palindrome = str =>
        {
            //abba
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                if (str[i] != str[j])
                {
                    return false;
                }
            }

            return true;
        };
        Console.WriteLine(palindrome("abcd"));
    }

    public void FuncExample()
    {
        Func<int, string> factorial = (number) =>
        {
            int f = 1;
            for (int i = number; i > 1; i--)
            {
                f = f * i;
            }

            return f.ToString();
        };
        Console.WriteLine(factorial(5));
    }
}