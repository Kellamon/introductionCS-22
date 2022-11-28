// 54. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1


Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int [] Fib = new int [N];

Fib[0] = 0;
Fib[1] = 1;

for(int i = 2; i < Fib.Length; i++)
{
    Fib[i] = Fib[i - 1] + Fib[i - 2];
}

PrintArray(Fib);

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}