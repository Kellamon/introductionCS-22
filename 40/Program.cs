// 40. Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10. 
//     Создайте массив, который является произведением пар чисел в одномерном массиве a. 
//     Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int[] RandomIntArray(int size = 20, int min = 0, int max = 200)
{
    int[] a = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        a[i] = random.Next(min, max + 1);
    }
    return a;
}

int[] PairMult(int[] a)
{
    int[] Mult = new int[a.Length / 2];
    int last = a.Length - 1;
    for (int i = 0; i < a.Length / 2; i++)
    {
        Mult[i] = a[i] * a[last];
        last = last - 1;
    }
    return Mult;
}
void PrintTo(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        System.Console.Write($"{a[i],5}");
    }
}
int[] a = RandomIntArray(20, 1, 10);
PrintTo(a);
System.Console.WriteLine();
System.Console.WriteLine();
PrintTo(PairMult(a));


