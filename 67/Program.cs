// 67. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

int[,] Random2DArray(int n, int m, int min = 0, int max = 5)
{
    int[,] a = new int[n, m];
    Random random = new Random();
    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
            a[i, j] = random.Next(min, max + 1); //+1 пишем потому что команда генерирует от мин до макс-1
    return a;
}

void Print2DArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)  // 0 измерение
    {
        for (int j = 0; j < a.GetLength(1); j++)  // измерение (элементы берутся тут => int[тут,тут] )
            System.Console.Write($"{a[i, j],4}");
        System.Console.WriteLine();
    }
}

int[,] a = Random2DArray(5, 5);
Print2DArray(a);
double[] b = new double[5];
for (int j = 0, k = 0; j < a.GetLength(1); j++)
{
    double summa = 0;
    for (int i = 0; i < a.GetLength(0); i++)
    {
        summa += a[i, j];
    }
    b[k] = summa / 5;
    Console.WriteLine("Среднее арифметическое столбца " + (j + 1) + " равно: " + b[k]);
    k++;
}

