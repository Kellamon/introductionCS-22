// 89. Подсчитать сумму цифр, встречающихся в строке
Console.WriteLine("Ввод строки: ");
string Line=Console.ReadLine();
int DigitsSum = 0;
foreach (char c in Line)
    if (char.IsDigit(c))
        DigitsSum += c - 48;
Console.WriteLine(DigitsSum);
