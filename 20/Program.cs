// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

double x=25;
double y=-20;
if (Check(x)&&Check(y))
{
System.Console.WriteLine("Точка находится в первой четверти");
}
if (!Check(x)&&Check(y))
{
System.Console.WriteLine("Точка находится во второй четверти");
}
if (Check(x)&&!Check(y))
{
System.Console.WriteLine("Точка находится в четвертой четверти");
}
if (!Check(x)&&!Check(y))
{
System.Console.WriteLine("Точка находится в третьей четверти");
}


bool Check(double a)
{
    return a>0;
}
