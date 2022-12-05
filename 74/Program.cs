// 74. Найти сумму цифр числа(Через Рекурсию)

int SumDigit(int N)
{
    if (N == 0) return 0;
    else return SumDigit(N / 10) + N % 10;
}

Console.WriteLine(SumDigit(123));