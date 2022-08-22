//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int S (int m, int n)
{
    if (m<n) return S(m+1,n)+m;
    else return m;
}

System.Console.WriteLine(S(4,8));