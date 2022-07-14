// Найти расстояние между точками в пространстве 2D
double Dis(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
}

double x1=2,x2=5,y1=5,y2=9;
System.Console.WriteLine(Dis(x1,y1,x2,y2));