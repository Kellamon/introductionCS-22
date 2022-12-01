// 65.  Написать подпрограмму, поиска элемента в двумерном массиве, подпрограмма возвращает позицию числа. Если элемент отсутствует, подпрограмма возвращает -1.

int[,] Random2DArray(int n, int m, int min = 0, int max = 30)
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

bool LinearSearch2DArray(int[,] a, int find, out int i, out int j)
{
    for (i = 0; i < a.GetLength(0); i++)

        for (j = 0; j < a.GetLength(1); j++)
            if (a[i, j] == find)
                return true;
    j = -1;//?
    return false;
}

int[,] a = Random2DArray(5, 5);
int find = 20;
//a[3, 2] = find;
Print2DArray(a);
int i, j;
if (LinearSearch2DArray(a, find, out i, out j))
{
    System.Console.WriteLine($"Element{find} found in position {i}, {j}");
}
else System.Console.WriteLine("-1");
