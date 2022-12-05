// 70. Показать натуральные числа от 1 до N, N задано (Через Рекурсию)



void NaturalNumbers(int N, int i)
{
    if (i <= N)
    {
        System.Console.WriteLine(i);
        NaturalNumbers(N, i + 1);
    }
}

NaturalNumbers(10, 1);