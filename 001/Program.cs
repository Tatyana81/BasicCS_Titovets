//Ввести с клавиатуры число и вывести квадрат этого числа
double a;
double b;
string? s;
s = Console.ReadLine();
a = Convert.ToDouble(s);
b = a*a;
Console.WriteLine($"{a}^2={b}");