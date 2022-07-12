// С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет.
// Пример. 259 - выводим 2.
int a;
System.Console.Write("Введите целое число ");
a=Convert.ToInt32(Console.ReadLine());

if (a/100>0)

{
    System.Console.WriteLine($"Третья цифра числа {a} равна {a/100%10}");
}

else 
{
    System.Console.WriteLine($"Третьей цифры у числа {a} нет");
}