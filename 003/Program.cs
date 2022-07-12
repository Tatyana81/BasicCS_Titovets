//С клавиатуры вводятся два числа a и b. Найти максимальное из них
double a,b;
System.Console.Write("Введите первое число ");
string? s=Console.ReadLine();
a=Convert.ToDouble(s);
System.Console.Write("Введите второе число ");
s=Console.ReadLine();
b=Convert.ToDouble(s);

if (a>b)
{
    System.Console.WriteLine($"Максимальное число {a}");
}

if (b>a)
{
    System.Console.WriteLine($"Максимальное число {b}");
}
else 
{
    System.Console.WriteLine("Числа равны");
}