Console.WriteLine("Введите первое число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число b");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    if (a > c)
    {
        Console.WriteLine(a + ", " + b + ", " + c + " -> " + a);
    }
    else
    {
        Console.WriteLine(a + ", " + b + ", " + c + " -> " + c);
    }
}
else if (b > a) 
{
if (b > c)
    {
        Console.WriteLine(a + ", " + b + ", " + c + " -> " + b);
    }
    else
    {
        Console.WriteLine(a + ", " + b + ", " + c + " -> " + c);
    }
}
