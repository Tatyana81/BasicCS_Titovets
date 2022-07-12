// Написать программу вычисления значения функции y = sin(a). (Класс Math)
double a,x,y;
System.Console.WriteLine("Введите значение угла в градусах");
string? s=Console.ReadLine();
a=Convert.ToDouble(s);
x=a*Math.PI/180; //переводим значение угла в радианы, т.к. в формуле используются данные в радианах
y=Math.Sin(x);
System.Console.WriteLine($"sin {a} = {y}");