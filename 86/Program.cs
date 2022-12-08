// 86. Подсчитать сколько раз определенный символ (например 'a') встречается в строке.

using System.Numerics;

string Letter = Console.ReadLine();
int count = 0;
char minValue = 'a';
char maxValue = 'a';
foreach (char c in Letter)
    if(char.IsBetween(c, minValue, maxValue)) count++;
Console.WriteLine(count);
