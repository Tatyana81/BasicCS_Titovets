// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]



int N=123;
int[] a=new int[N];
Random random=new Random();
for(int i=0;i<a.Length;i++)
a[i]=random.Next(-100,101);

for(int i=0;i<a.Length;i++)
System.Console.Write($"{a[i],4}");

int count=0;
for(int i=0;i<a.Length;i++)
    if (a[i]>=10 && a[i]<=99)
       count++;


System.Console.WriteLine();
System.Console.WriteLine($"количество элементов из отрезка [10,99] {count}");

