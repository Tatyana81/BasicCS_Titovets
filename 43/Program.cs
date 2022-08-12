// С клавиатуры вводится число N. Затем вводятся N чисел. 
//Определить сколько чисел больше 0 введено с клавиатуры

System.Console.ReadLine();
string ? s = Console.ReadLine();
string[] ss=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
int[] a=Array.ConvertAll<string,int>(ss,int.Parse);
int k;
Solution(a, out k);
System.Console.WriteLine(k);  


void Solution (int[] a,out int k)
{
    k=0;
    for(int i=0;i<a.Length;i++)
        if (a[i]>0)
            k++;
}





