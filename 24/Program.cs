// 24. Вывести на экран таблицу квадратов чисел от 1 до N

System.Console.WriteLine("Для вывода таблицы введите число: N = ");
int N=Convert.ToInt32(Console.ReadLine());
void NumberSquared(int N)
{
    System.Console.WriteLine("_Число_/_Квадрат_");
    for (int i = 1; i <= N; i++)
    {
        System.Console.WriteLine($"{i,2}{i*i,8}");
    }
    return;
}
NumberSquared(N);



