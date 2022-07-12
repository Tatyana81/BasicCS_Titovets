// Вывести на экран числа от -N до N
int i=0;
int N;
System.Console.Write("Введите целое число ");
N= Convert.ToInt32(Console.ReadLine());
i=-N;

while(i<=N)
{
System.Console.Write($"{i} ");
i=i+1;
}

