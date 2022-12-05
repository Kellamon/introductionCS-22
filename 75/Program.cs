// 75. Написать программу вычисления функции Аккермана (Через Рекурсию)

Console.WriteLine("Введите число N с условием N => 0");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число M с условием M => 0");
int m = int.Parse(Console.ReadLine());


int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.WriteLine($"A({n},{m}) = {Akkerman(m,n)}");

