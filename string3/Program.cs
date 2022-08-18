// С клавиатуры вводится строка разделенная точкой. 
//Подсчитать количество символов до точки


string s=Console.ReadLine();
char[] cc=s.ToArray();
s=new String(cc);
int count=0;
for(int i=0;i<cc.Length;i++)
    if (s[i]=='.') 
        {System.Console.WriteLine(count);return;}
        else count++;
