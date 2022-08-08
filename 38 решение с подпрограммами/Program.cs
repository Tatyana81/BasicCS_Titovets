// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]


int[] a;
Init(out a);
Print(a);
int count;
Solution(a, out count);
System.Console.WriteLine();
System.Console.WriteLine($"количество элементов из отрезка [10,99] {count}");










void Init(out int[] a,int Length=123)
{
    a=new int[Length];
    Random random=new Random();//псевдослучайные числа
    for(int i=0;i<a.Length;i++)
            a[i]=random.Next(-1000,100);
}

void Solution (int[] a,out int count)
{
    count=0;
    for(int i=0;i<a.Length;i++)
        if (a[i]>=10 && a[i]<=99)
            count++;
}


void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],6}");
}
