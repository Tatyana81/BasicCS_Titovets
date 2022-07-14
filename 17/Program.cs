//Дано число обозначающее день недели. Выяснить является номер дня недели выходным

int a=6;

bool Day (int a)
    {
        return a==6 || a==7;
    }

if (Day(a))
{
    System.Console.WriteLine("Является выходным");
}
else 
{
    System.Console.WriteLine("Не является выходным");
}
