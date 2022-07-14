// Подсчитать сумму цифр в числе

int a=15;
int sum=0;

int Number (int a)
{
    return a%10;
}

while (a>0)
{
    sum=sum+Number(a);
    a=a/10;
}
System.Console.WriteLine(sum);
