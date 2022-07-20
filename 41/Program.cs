// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

int N=8;
double[] a=new double[N];
Random random=new Random();

for(int i=0;i<a.Length;i++)
a[i]=random.Next(0,10); // как заполнить вещественными, не соображу

double max=a[0];
double min=a[0];
for(int i=0;i<a.Length;i++)
    {
    if (a[i]>max) max=a[i];
    if (a[i]<min) min=a[i];
    }

for(int i=0;i<a.Length;i++)
System.Console.Write($"{a[i],4}");
System.Console.WriteLine(   );
System.Console.WriteLine($"Разница между макс.и мин. элементами равна  {max-min}");

