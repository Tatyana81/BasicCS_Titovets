// Вывести на экран кубы чисел от 1 до N

int a=5;
int count=0;

int Number (int a)
{
    return Convert.ToInt32(Math.Pow(a,3));
}

while (count<a)
{
    count++;
    System.Console.Write(Number(count)+" ");
}


