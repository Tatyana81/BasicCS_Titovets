//  Определить являются ли введенные с клавиатуры символы правильной записью целого числа. 
//Вычислить сумму цифр введенного числа

string s=Console.ReadLine();
char[] cc=s.ToArray();
s=new String(cc);
int count=0;
for(int i=0;i<cc.Length;i++)
    if (s[i]>='0'&&s[i]<='9') 
        count=count+(int)(char.GetNumericValue(s[i]));
        else 
        {System.Console.WriteLine("не целое цисло");return;};
System.Console.WriteLine(count);

