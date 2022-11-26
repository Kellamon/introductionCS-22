// Переворот массива
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

void PrintTo(int[] a, int tab=5)
{
    string formatString="{0,"+tab+"}";
    for (int i = 0; i < a.Length; i++)
    {
        
        System.Console.Write(formatString, a[i]);
    }
}

/*int Solve(int[] a)
{
    int count = 0;
    foreach (int el in a)
    {
        if (el>=10 && el<=99)
        count++;
    }
    return count;
}*/

void Swap(ref int a, ref int b)
{
    int t=a;
    a=b;
    b=t;
}

void Reverse(int[] a)
{
    for (int i = 0; i < a.Length/2; i++)
    {
        Swap(ref a[i], ref a[a.Length-1-i]); // ссылаемся на значения массива, по этому используем ref
    }
}
int M=10;
int[] a=RandomIntArray(M, 0, 200);
PrintTo(a, 5);
// можно использовать встроенные метод для оборатного массива
//  a=a.Reverse(),ToArray(); по сути он создает новый массив и использует два массива, следовательно не стоит злоупотреблять
Reverse(a);
System.Console.WriteLine();
PrintTo(a, 5);