// See https://aka.ms/new-console-template for more information

//int a = 10;
// Console.WriteLine("The value for a is " + a);
//
// double b = 2.42432;
// Console.WriteLine($"The value for b is {b}");
//
// float c = 4.34f;
// Console.WriteLine(c);
//
// decimal d = 3.343m;
// Console.WriteLine(d);

using System.Text;
using ConsoleApp1;

// string s = "hello World";
// //s[0] = 'H';
// StringBuilder sb = new StringBuilder("hello World");
// Console.WriteLine($"before change: {sb}");
// sb[0] = 'H';
// Console.WriteLine($"after change: {sb}");
// Console.WriteLine(s);

//
// bool flag = true;
// Console.WriteLine(flag);
//
// int? price = null;
// if (price.HasValue)
// {
//     Console.WriteLine(price.Value);
// }
// else
// {
//     Console.WriteLine("price doesn't have any value");
// }

// int sunday = 1;
// int monday = 2;
// int tuesday = 3;
// int wednesday = 4;
// int thursday = 5;
// int friday = 6;
// int saturday = 7;
//
// int dayOfWeek = 17;
// if (dayOfWeek == monday)
// {
//     Console.WriteLine("it's Monday");
// }
//
// DaysOfWeek today = DaysOfWeek.Monday;
// Console.WriteLine(today);

ParamsPassing demo = new ParamsPassing();
// int x = 30;
// int y = 10;
// string c = "hello";
// Console.WriteLine($"Before calling passing by value method: x = {x}, y = {y}, c = {c}");
// demo.PassingByValue(x, y, c);
// Console.WriteLine($"After calling passing by value method: x = {x}, y = {y}, c = {c}");
//
// Console.WriteLine("-------");
// Console.WriteLine($"Before calling passing by reference method: x = {x}, y = {y}, c = {c}");
// demo.PassingByReference(ref x, ref y, ref c);
// Console.WriteLine($"After calling passing by reference method: x = {x}, y = {y}, c = {c}");

demo.AreaOfCircle(10);
demo.AreaOfCircle(10, 3);

string str;
Console.WriteLine(demo.IsAuthentic("Rebecca", "Antra123", out str));
Console.WriteLine(str);


Console.WriteLine(demo.AddNumbers(20,30));
Console.WriteLine(demo.AddNumbers(20,30,30,40));

//demo.AddThreeNumbers(1,2,3);
