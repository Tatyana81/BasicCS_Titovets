// С клавиатуры вводятся три числа. Найти максимальное из трех чисел
double a,b,c,max;
System.Console.Write("Введите первое число ");
string? s=Console.ReadLine();
a=Convert.ToDouble(s);
System.Console.Write("Введите второе число ");
s=Console.ReadLine();
b=Convert.ToDouble(s);
System.Console.Write("Введите третье число ");
s=Console.ReadLine();
c=Convert.ToDouble(s);
max=a;

if (b>max)
{
    max=b;
}

if (c>max)
 {
     max=c;
 }


System.Console.WriteLine($"Максимальное число {max}");