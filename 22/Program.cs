// Программа проверяет пятизначное число на палиндромом.
int a=15251;

bool Pal (int b, int c)
{
    return b==c;
}

if (Pal(a%10,a/10000) && Pal(a/10%10,a/1000%10))
{
    System.Console.WriteLine($"Число {a} является палиндромом");
}
else 
{
     System.Console.WriteLine($"Число {a} не является палиндромом");
}