// Написать программу, которая обменивает элементы первой строки и последней строки

int[,] a;
a = Create2DArray(4, 10);
Print(a);
Solve (a);
System.Console.WriteLine();
Print(a);


void Print(int[,] a)
{
for (int i = 0; i < a.GetLength(0); i++)//перебираем строки
{
for (int j = 0; j < a.GetLength(1); j++)//перебираем столбцы
System.Console.Write($"{a[i, j],4}");
System.Console.WriteLine();
}
}

int[,] Create2DArray(int n, int m, int min = 0, int max = 100)
{
int[,] a = new int[n, m];//создаем массив
Random random = new Random();
for (int i = 0; i < a.GetLength(0); i++)//перебираем строки
for (int j = 0; j < a.GetLength(1); j++)//перебираем столбцы
a[i, j] = random.Next(min, max + 1);
return a;
}

void Solve (int[,] a)
{
int n;
for (int j = 0; j < a.GetLength(1); j++)//перебираем столбцы
    {
        n=0;
        n=a[0,j];
        a[0,j]=a[a.GetLength(0)-1,j];
        a[a.GetLength(0)-1,j] =n;
    }

}

