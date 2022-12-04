// Сумма цифр

/*
int SumDigit(int N)
{
    if (N == 0) return 0;
    else return SumDigit(N / 10) + N % 10;
}

Console.WriteLine(SumDigit(123));
*/

int n = int.Parse(Console.ReadLine());
Console.WriteLine(n / 100);