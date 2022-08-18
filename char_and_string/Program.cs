/*char c='a';//2^16=65536
ConsoleKeyInfo ck;
do
{
    ck=Console.ReadKey();
    System.Console.WriteLine((int)ck.KeyChar);
    System.Console.WriteLine("IsDigit:"+char.IsDigit(ck.KeyChar));
    System.Console.WriteLine("IsControl:"+char.IsControl(ck.KeyChar));
    System.Console.WriteLine("IsLetter:"+char.IsLetter(ck.KeyChar));
    
}
while(ck.Key!=ConsoleKey.Escape);
string s="s";
System.Console.WriteLine('a'.ToString()+'b');
if (c>='A' && c<='Z') System.Console.WriteLine("Latin");
if (c>='a' && c<='z') System.Console.WriteLine("Latin");
//2^8=256//Windows-1251, MD-DOS-866, KOИ-8
*/

/*
string str="Hello";
System.Console.WriteLine(str[0].ToString()+str[1]);
for(int i=0;i<str.Length;i++)
  if (str[i]>='A' && str[i]<='Z')
        System.Console.WriteLine(str[i]);
//immutable- неизменяемые
//str[0]='h';
char[] cc=str.ToArray();
cc[0]='h';
str=new string(cc);
*/

/*
string str="Hello";
str=str.Remove(0,1);
System.Console.WriteLine(str);
*/

System.Diagnostics.Stopwatch stopwatch=new System.Diagnostics.Stopwatch();
stopwatch.Start();
string s="";
/*
for(int i=0;i<30000;i++)
    s=s+"abcdefghijklmnopqrstvwxyz";
stopwatch.Stop();
System.Console.WriteLine(stopwatch.ElapsedMilliseconds);    
stopwatch.Reset();
stopwatch.Start();
System.Text.StringBuilder sb=new System.Text.StringBuilder("");
for(int i=0;i<30000;i++)
    sb.Append("abcdefghijklmnopqrstvwxyz");
stopwatch.Stop();
System.Console.WriteLine(stopwatch.ElapsedMilliseconds);    
*/

s.Concat("123");//s=s+"123";
s="1111";
s=s.Replace('1','2');
s.Contains('1');
s=s.Insert(1,"0");
System.Console.WriteLine(s);
System.Console.WriteLine(s.IndexOf("0"));

string s1="123";
if (s1==s);
if (s.CompareTo(s1)<0);//aaaa aaaaaa
if (String.Compare(s,1,s1,1,2)>0);


Random random1=new Random();
Random random2=new Random();
System.Console.WriteLine(random1==random2);

