Console.WriteLine("Введите первое число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число b");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("a = "+ a + "; b ="+ b +" -> max = " +a);
}
else if (b > a)
{
    Console.WriteLine("a = "+ a + "; b = "+ b +" -> max = " +b);
}
else
{
    Console.WriteLine("a = "+ a + "; b = "+ b +" числа равны");
}

//Console.WriteLine("Введите положительное 3х значное число");
//int n = Convert.ToInt32(Console.ReadLine());
//int lastDigit = 0;
//if (100 <= n && n <= 999) 
//{
//lastDigit = n % 10;
//Console.WriteLine(lastDigit);
//}
//else 
//{
//    Console.WriteLine("Вы ввели неверное число");
//}

//int a = 4;
//int b = -3;
//int c = -7;
//
//Console.WriteLine (a*a);
//Console.WriteLine (b*b);
//Console.WriteLine (c*c);
