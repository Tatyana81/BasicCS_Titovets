// Дано число больше 9. Вывести на экран  вторую цифру числа с конца
// Пример. Число 18. Выводим 1
int a;
System.Console.Write("Введите целое число больше 9 ");
a=Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Вторая цифра числа {a} с конца равна {a/10%10}");

