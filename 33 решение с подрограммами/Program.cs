// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] a;
Init(out a);
Print(a);















void Init(out int[] a,int Length=8)
{
    a=new int[Length];
    Random random=new Random();//псевдослучайные числа
    for(int i=0;i<a.Length;i++)
            a[i]=random.Next(0,2);
}


void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],4}");
}
