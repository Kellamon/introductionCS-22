// Списки

List<int> temp;
temp=new List<int>(); // если заполнить скобки, то за ранее сформируем запрос на использование памяти, что может положительно сказаться на работе программы
for (int i = 0; i < 7; i++)
{
    temp.Add(Convert.ToInt32(Console.ReadLine()));
}
double s=0;
for (int i = 0; i < 7; i++)
{
    s=s+temp[i];
}
System.Console.WriteLine(s/temp.Count);