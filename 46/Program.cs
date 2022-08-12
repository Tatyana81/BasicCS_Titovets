//С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1
//f(n)=f(n-1)+f(n-2)
//0 1 1 2 3 5 8 13 ....

int N;
System.Console.Write("Введите число ");
string? s=Console.ReadLine();
N=Convert.ToInt32(s);

int Fibon (int n)
{
    if (n==1) return 0;
        else
            if (n==2) return 1;
                else return Fibon(n-1)+Fibon (n-2);
}

for (int i=1; i<=N; i++)
    System.Console.WriteLine(Fibon(i));

 