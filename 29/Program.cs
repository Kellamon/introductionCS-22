// 29. Подсчитать сумму цифр в числе. Сделать подпрограмму.

System.Console.WriteLine("Введите число: ");
int Digits=Convert.ToInt32(Console.ReadLine());

int DigitsSum(int arg1)
{
    int result = 0;
    while (Math.Abs(arg1) > 0)
    {
        result += arg1 % 10;
        arg1 /= 10;
    }
    return result;
}
System.Console.WriteLine($"Сумма цифр в числе {Digits} = {DigitsSum(Digits)}");