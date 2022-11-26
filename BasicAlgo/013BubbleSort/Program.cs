// Пузырьковая сортировка(самая простая для понимания и самая сложная для исполнения) имеет О(N^2)
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

void Swap(ref int a, ref int b)
{
    int t=a;
    a=b;
    b=t;
}

void BubbleSort(int[] a, out int count)
{
    count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        for (int j= 0; j < a.Length-1; j++) // можно улучшить, если добавить вычитание элемента "i" j<a.Length-1-i
        {
            if (a[j]>a[j+1]) // основной элемент сравнения для осуществления сортировки пузырькового типа
            {
                Swap(ref a[j], ref a[j+1]);
            }
            count++;
        }
    }
}

int[] a=RandomIntArray(10, 0, 10);
PrintTo(a);
int count=0;
BubbleSort(a, out count);
System.Console.WriteLine();
PrintTo(a);
System.Console.WriteLine();
System.Console.WriteLine(count);