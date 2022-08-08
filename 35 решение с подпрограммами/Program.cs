//Написать программу замены элементов массива на противоположные


int[] a;
Init(out a);
Print(a);
Zamena(a);
System.Console.WriteLine();
Print(a);
















void Init(out int[] a,int Length=10,int min=-10,int max=10)
{
    a=new int[Length];
    Random random=new Random();//псевдослучайные числа
    for(int i=0;i<a.Length;i++)
            a[i]=random.Next(min,max+1);
}

void Zamena(int[] a)
{
    for(int i=0;i<a.Length;i++)
       a[i]=-a[i];
}


void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],4}");
}

