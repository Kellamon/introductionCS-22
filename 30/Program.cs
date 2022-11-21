// 30. Написать программу вычисления произведения чисел от 1 до N

System.Console.WriteLine("Введите число N: ");
int N=Convert.ToInt32(Console.ReadLine());

int Factorial(int arg1)
{
    int result=1;
    for (int i = 1; i <= arg1; i++) result *= i;
    return result;
}
System.Console.WriteLine($"Фрактал числа {N} = {Factorial(N)}");