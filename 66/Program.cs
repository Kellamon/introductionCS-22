// 66. Написать подпрограмму, которая в квадратной матрице чисел находит сумму элементов главной диагонали

int[,] Create2DArray(int n, int m)
{
    int[,] a = new int[n, m];
    Random random = new Random();
    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
            a[i,j]=i+j;
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

int SumMainDiagonal(int[,] a)
{
    int s=0;
    if (a.GetLength(0)!=a.GetLength(1))
    throw new ArgumentException("Матрица не квадратная");  // позволяет организовать остановку программы из за исключения
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (i==j) s += a[i,j]; // более правильно будет изменить код на s += a[i,i]. позволит ускорить код
        }
    }
    return s;
}

int [,] a=Create2DArray(4,4);
Print2DArray(a);
System.Console.WriteLine(SumMainDiagonal(a));