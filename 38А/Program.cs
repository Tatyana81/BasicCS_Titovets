// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

//ниже кусок для проверки, чтобы ввести массив вручную, 
//сама программа заполняет случайными числами массив.

using System;
Console.WriteLine("введите массив чисел через пробел");
string s=Console.ReadLine();
string[] ss=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
double[] a=Array.ConvertAll<string,double>(ss,double.Parse);

/*этот кусок программы заполняет случайными вещественными числами массив
double[] a; 
InitDoubles(out a,2);*/

double min,max;
FindMinMax(a,out min,out max);
Print(a);
System.Console.WriteLine();
System.Console.WriteLine(max-min);



void InitDoubles(out double[] a,int Length=10,int min=0,int max=100)
{
    a=new double[Length];
    Random random=new Random();//псевдослучайные числа
    for(int i=0;i<a.Length;i++)
            a[i]=random.Next(min,max+1)/1000.0;
}

void FindMinMax(double[] a,out double min, out double max)
{
    min=a[0];
    max=a[0];
    for(int i=1;i<a.Length;i++)
    {
        if (a[i]>max) max=a[i];
        if (a[i]<min) min=a[i];
    }
}


void Print(double[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],6:F3} ");
}