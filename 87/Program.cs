// 87. Удалить среднюю букву при нечетной длине строки и две средние буквы при четной длине строки

string s=Console.ReadLine();
string s1;
int m = s.Length / 2;
if (s.Length%2==0)
{
    s1 = s.Remove(m - 1, 2);
}
else
{
    s1=s.Remove(m-1, 1);
}
Console.WriteLine(s1);