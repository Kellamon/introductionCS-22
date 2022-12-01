// 68. Написать программу, которая обменивает элементы первой строки и последней строки

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

void Swap(int[,] a) // reference-ccылка 
{
    for (int i = 0; i < a.GetLength(1); i++)
        for (int j = 0; j < a.GetLength(1); j++)
        {
            int temp = a[0, j];
            a[0, j] = a[a.GetLength(0)-1, j];
            a[a.GetLength(0)-1, j] = temp;
        }
}

int[,] a = Random2DArray(5, 5);
Print2DArray(a);
System.Console.WriteLine();
Swap(a);
Print2DArray(a);
