// Дано число из  диапозона  [10, 99]. Показать наибольшую цифру числа
int a;
System.Console.Write("Введите целое число из диапозона [10.99] ");
a=Convert.ToInt32(Console.ReadLine());

if ((a/10)>(a%10))

{
    System.Console.WriteLine($"Наибольшая цифра числа {a} равна {a/10}");
}

else 
{
    System.Console.WriteLine($"Наибольшая цифра числа {a} равна {a%10}");
}