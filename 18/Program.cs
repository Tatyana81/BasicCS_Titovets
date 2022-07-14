//По двум заданным числам проверять является ли одно квадратом другого. Используйте подпрограмму.

int a=26;
int b=5;
if (Check(a,b))
{
System.Console.WriteLine("Является");
}
else
{
System.Console.WriteLine("Не является");
}


bool Check(int a, int b)
{
    return b*b==a || a*a==b;
}


