namespace ConsoleApp4;

public class ExceptionHandlingDemo
{
    private int Divide(int number, int divisor)
    {
        return number / divisor;
    }

    public int Calculate(int num1, int num2, string operation)
    {
        if (operation == "/")
        {
            return Divide(num1, num2);
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }
    }
}