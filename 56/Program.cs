// 56. Написать программу копирования массива

int[] a = RandomIntArray(10, 0, 10);
PrintTo(a);
System.Console.WriteLine();


int[] SecArr = new int[a.GetUpperBound(0) + 1];

Array.Copy(a, SecArr, a.GetUpperBound(0) + 1);

PrintTo(SecArr);

int[] RandomIntArray(int size = 10, int min = 0, int max = 10)
{
    int[] a = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        a[i] = random.Next(min, max + 1);
    }
    return a;
}

void PrintTo(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        System.Console.Write($"{a[i],5}");
    }
}

