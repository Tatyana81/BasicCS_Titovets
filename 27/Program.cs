// Возведите число А в натуральную степень B используя цикл
int a=5,b=3;
int count=1;

int c=a;
int Power (int a)
{
    return a*c;
}

while (count<b)
{
    a=Power(a);
    count++;
}

System.Console.WriteLine(a);