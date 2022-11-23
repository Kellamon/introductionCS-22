// Массив из случайных чисел

int[] a;
a = new int[10];

int[] RandomIntArray(int size, int min, int max)
{
    int[] a = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
        a[i] = random.Next(min, max);
    return a;
}

void PrintTo(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        System.Console.Write($"{a[i],5}");
    }
}

int[] m=RandomIntArray(10,-100,100);
PrintTo(m);

