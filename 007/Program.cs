// Выяснить является ли число чётным
int a;
System.Console.Write("Введите число ");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);

if (a%2==0)
{
    System.Console.WriteLine($"Число {a} является четным");
}
else 
{
System.Console.WriteLine($"Число {a} является нечетным");
}

