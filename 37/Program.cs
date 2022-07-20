//Задать массив, заполнить случайными положительными трёхзначными числами.
//Показать количество нечетных\четных чисел


int N=4;
int[] a=new int[N];
Random random=new Random();
for(int i=0;i<a.Length;i++)
a[i]=random.Next(100,1000);

for(int i=0;i<a.Length;i++)
System.Console.Write($"{a[i],4}");

int amountOdd=0;
int amountEven=0;
for(int i=0;i<a.Length;i++)
    if (a[i]%2==0)
       amountEven++;
       else amountOdd++;


System.Console.WriteLine();
System.Console.WriteLine($"кол-во четных чисел массива {amountEven}");
System.Console.WriteLine($"кол-во нечетных чисел массива {amountOdd}");