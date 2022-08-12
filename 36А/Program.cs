// : Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

//ниже кусок для проверки, чтобы ввести массив вручную, 
//сама программа заполняет случайными числами массив.

/*using System;
Console.WriteLine("введите массив чисел через пробел");
string s=Console.ReadLine();
string[] ss=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
int[] a=Array.ConvertAll<string,int>(ss,int.Parse);*/

int N=4;
int[] a=new int[N];
Random random=new Random();//псевдослучайные числа
for(int i=0;i<a.Length;i++)
a[i]=random.Next(0,11);

for(int i=0;i<a.Length;i++)
System.Console.Write($"{a[i],4}");

int sum=0;
for(int i=1;i<a.Length;i=i+2)
//sum+=a[i];
sum=sum+a[i];
System.Console.WriteLine();
System.Console.WriteLine(sum);
