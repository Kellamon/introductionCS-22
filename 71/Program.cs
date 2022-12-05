// 71. Показать натуральные числа от N до 1, N задано (Через Рекурсию)

void NaturalNumbers(int N, int i)
{
    if (i <= N)
    {
        System.Console.WriteLine(N);
        NaturalNumbers(N-1, i);
    }
}

NaturalNumbers(10, 1);