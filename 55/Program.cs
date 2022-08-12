// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.


int[,] a;
double[] b;
a = Create2DArray(2, 4);
b= CreateB (a.GetLength(1));
Print(a);
System.Console.WriteLine("среднее арифметическое каждого из столбцов");
PrintB(b);



void Print(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)//перебираем строки
    {
        for (int j = 0; j < a.GetLength(1); j++)//перебираем столбцы
        System.Console.Write($"{a[i, j],6}");
        System.Console.WriteLine();
    }
}

void PrintB(double[] b)
{
for (int i = 0; i < a.GetLength(1); i++)//перебираем строки
System.Console.Write($"{b[i],6}");
}

int[,] Create2DArray(int n, int m, int min = 0, int max = 10)
{
    int[,] a = new int[n, m];//создаем массив
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)//перебираем строки
        for (int j = 0; j < a.GetLength(1); j++)//перебираем столбцы
            a[i, j] = random.Next(min, max + 1);
    return a;
}

double [] CreateB (int n)
{double[] b=new double[n];//создаем массив
    {
        for (int j = 0; j < a.GetLength(1); j++)//перебираем столбцы
            {
                double count=0;
                for (int i = 0; i < a.GetLength(0); i++)//перебираем строки
                    {
                        count=count+a[i,j];
                    }
                b[j]=count/a.GetLength(0);
                System.Console.WriteLine(b[j]);
            }
    }
    return b;
}