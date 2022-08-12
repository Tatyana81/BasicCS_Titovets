//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


/* ниже кусок для проверки, чтобы ввести массив вручную, 
сама программа заполняет случайными числами массив.


using System;
Console.WriteLine("введите массив чисел через пробел");
string s=Console.ReadLine();
string[] ss=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
int[] a=Array.ConvertAll<string,int>(ss,int.Parse);*/

int[] a;
Init(out a);
Print(a);
int amountEven;
Solution(a,out amountEven);
System.Console.WriteLine();
System.Console.WriteLine($"кол-во четных чисел массива {amountEven}");


void Init(out int[] a,int Length=10)
{
    a=new int[Length];
    Random random=new Random();//псевдослучайные числа
    for(int i=0;i<a.Length;i++)
            a[i]=random.Next(100,1000);
}

void Solution (int[] a, out int amountEven)
{
        amountEven=0;
    for(int i=0;i<a.Length;i++)
    if (a[i]%2==0)
       amountEven++;
      
}


void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],6}");
}