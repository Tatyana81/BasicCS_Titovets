﻿// Вывести на экран последнюю цифру целого числа введенного с клавиатуры.
//Пример. Число 672. Выводим цифру 2.

int a;
System.Console.Write("Введите целое число ");
a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Последняя цифра целого числа {a} равна {a%10}");