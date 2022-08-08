//Задать массив, заполнить случайными положительными трёхзначными числами.
//Показать количество нечетных\четных чисел

int[] a;
Init(out a);
Print(a);
int amountOdd, amountEven;
Solution(a, out amountOdd, out amountEven);
System.Console.WriteLine();
System.Console.WriteLine($"кол-во четных чисел массива {amountEven}");
System.Console.WriteLine($"кол-во нечетных чисел массива {amountOdd}");








void Init(out int[] a,int Length=10)
{
    a=new int[Length];
    Random random=new Random();//псевдослучайные числа
    for(int i=0;i<a.Length;i++)
            a[i]=random.Next(100,1000);
}

void Solution (int[] a,out int amountOdd, out int amountEven)
{
    amountOdd=0;
    amountEven=0;
    for(int i=0;i<a.Length;i++)
    if (a[i]%2==0)
       amountEven++;
       else amountOdd++;
}


void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],6}");
}

