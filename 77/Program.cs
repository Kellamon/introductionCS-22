// 77. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности 0 и 1 

Console.WriteLine("Введите значение: ");
int N = Convert.ToInt32(Console.ReadLine());

double[] FibWithRecursion(int size) 
{
    double[] array = new double[size];
    array[0] = 0;
    array[1] = 1;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Fib(i);
    }
    return array;
}

double Fib(double N)
{
    if (N == 0 || N == 1) return 1;
    else return Fib(N - 1) + Fib(N - 2);
}

void PrintArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}

double[] a = FibWithRecursion(N);
PrintArray(a); 