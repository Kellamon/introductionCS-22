// 69. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

int[,] Random2DArray(int n, int m, int min = 0, int max = 10)
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

void Sort2DArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)    // сортирует по строкам
        for (int k = 0; k < a.GetLength(0); k++)
            for (int j = 0; j < a.GetLength(0) - 1; j++)
                if (a[i, j] > a[i , j+ 1])
                {
                    int t = a[i, j];
                    a[i, j] = a[i, j + 1];
                    a[i, j + 1] = t;
                }
}

int[,] a = Random2DArray(5, 5);
Print2DArray(a);
System.Console.WriteLine();
Sort2DArray(a);
Print2DArray(a);
