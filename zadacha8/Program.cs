Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());

if (a>0)
{
    for (int i=1; i<=a; i++)
{
    if (i%2==0)
    {
        Console.Write(i + " ");
    }

}
}
else
{
    Console.Write("четных чисел нет");
}


