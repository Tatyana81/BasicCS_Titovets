﻿// Удалить вторую цифру целого числа введенного с клавиатуры.
// Пример. Число 89 - вывести число 9. Число 158 - вывести 18
int a;
System.Console.Write("Введите целое число ");
a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Число {a} без второй цифры равно {a/10/10*10+(a%10)}");
