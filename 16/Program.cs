// Дано число. Проверить кратно ли оно 7 и 23
int a=14;
bool b=a%7==0 && a%23==0;
System.Console.WriteLine(b);
if (b)
{
    System.Console.WriteLine("Кратно");
}

else
{
    System.Console.WriteLine("Не кратно");
}