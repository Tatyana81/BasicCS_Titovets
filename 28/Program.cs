//28. Определить количество цифр в числе. Сделать подпрограмму.
System.Console.WriteLine(CountDigits(1528));

int CountDigits(int N)
{
if (N==0) return 1;
int k=0;
while(N!=0)
{
k++;
N/=10;
}
return k;
}
