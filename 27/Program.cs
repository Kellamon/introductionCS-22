// 27. Возведите число А в натуральную степень B используя цикл

System.Console.WriteLine("Введите число A: ");
int A=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B: ");
int B=Convert.ToInt32(Console.ReadLine());

int DigitDegree(int arg1, int arg2)
{
    int result = 1;
    for (int i = 1; i <= arg2; i++)
    {
        result *= arg1;
    }
    return result;
}
System.Console.WriteLine($"{A} в степени {B} = {DigitDegree(A,B)}");