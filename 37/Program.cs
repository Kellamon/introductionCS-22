// 37. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] RandomIntArray(int size = 10, int min = 100, int max = 999)
{
    int[] a = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        a[i] = random.Next(min, max + 1);
    }
    return a;
}

int[] EvenOddNumber(int[] a, int Odd = 0, int Even = 0)
{
    int[] result = new int[2];
    for (int i = 0; i <= a.Length - 1; i++)
    {
        if (a[i] % 2 == 0)
            Even++;
        else Odd++;
    }
    result[0] = Even;
    result[1] = Odd;
    return result;
}


void PrintTo(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        System.Console.Write($"{a[i],5}");
    }
}
int[] a = RandomIntArray(10, 100, 999);
PrintTo(a);
System.Console.WriteLine();
int[] result = EvenOddNumber(a);
Console.WriteLine($"в данном массиве {result[0]} четных и {result[1]} нечетных значений");


// Помощь от Ольги(спасибо ей большое). Еще один пример, как правильно обращаться к методам
/*
int[] RandomIntArray(int size=10, int min=100, int max=999)
{
    int[] a=new int[size];
    Random random=new Random();
    for (int i = 0; i < size; i++)
    {
        a[i]=random.Next(min,max+1);
    }
    return a;
}

int[] EvenOddNumber(int[] a, int Odd=0, int Even=0)
{
    int[] result = new int [2];
    for (int i = 0; i <= a.Length - 1; i++)
    {
        if(a[i]%2==0)
        Even++;
        else Odd++;
    }
    result[0] = Even;
    result[1] = Odd;
    return result;
}


void PrintTo(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        System.Console.Write($"{a[i],5}");
    }
}

int[] a=RandomIntArray(10,100,999);
int[] array = RandomIntArray(20, 10, 99);
PrintTo(a);

System.Console.WriteLine();
int [] result = EvenOddNumber(a);
int[] result2 = EvenOddNumber(array);
Console.WriteLine($"в данном массиве {result[0]} четных и {result[1]} нечетных значений");
PrintTo(array);
System.Console.WriteLine();
Console.WriteLine($"в данном массиве {result2[0]} четных и {result2[1]} нечетных значений");*/