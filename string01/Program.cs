//1. С клавиатуры вводится строка - перевернуть ее.

/*string s=Console.ReadLine();
for(int i=s.Length-1;i>=0;i--)
    System.Console.Write(s[i]);
*/
/*
//2. Даны две строки. Можно ли из символов одной строчки, составить другую строчку
//abcd cdab
//13254 42135
//12345 12345
string s1=Console.ReadLine();
string s2=Console.ReadLine();
char[] cc1=s1.ToArray();
Array.Sort(cc1);
string ss1=new String(cc1);
char[] cc2=s2.ToArray();
Array.Sort(cc2);
string ss2=new String(cc1);
//System.Console.WriteLine(ss1);
//System.Console.WriteLine(ss2);
if (ss1==ss2) System.Console.WriteLine("Yes"); else System.Console.WriteLine("No");
//System.Console.WriteLine(new string(s.Reverse().ToArray()));
*/
//3. Вводится строка из латинских. Преобразовать все латинские большие буквы в маленькие
//LATIN
//latin
string s=Console.ReadLine();
System.Console.WriteLine(s.ToLower());
