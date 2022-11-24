// 38. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] RandomIntArray(int size = 123, int min = 0, int max = 200)
{
    int[] a = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        a[i] = random.Next(min, max + 1);
    }
    return a;
}

int CountEl(int[] a)
{
    int count = 1;
    for (int i = 0; i < a.Length; i++)
    {
       if (a[i] >= 10 && a[i] <= 99)
       {
            count++;
       }
    }
    return count;
}

void PrintTo(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        System.Console.Write($"{a[i],5}");
    }
}
int[] a = RandomIntArray(123, 0, 123);
PrintTo(a);
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine($"на отрезке [10, 99] {CountEl(a)} элемента(ов)");
