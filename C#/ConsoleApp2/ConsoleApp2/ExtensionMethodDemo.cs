namespace ConsoleApp2;

public static class ExtensionMethodDemo
{
    public static string EvenOrOdd(this int num)
    {
        if (num % 2 == 0)
        {
            return "Even";
        }

        return "Odd";
    }
}