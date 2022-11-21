// 26. Найти сумму чисел от 1 до А

System.Console.WriteLine("Ввод числа: ");
int Arg1=Convert.ToInt32(Console.ReadLine());
int DigitSum(int Arg1)
{
    int result=0;
    for (int i = 1; i <= Arg1; i++)
    {
        result += i;
    }
    return result;
}
System.Console.WriteLine($"Сумма чисел от 1 до {Arg1} = {DigitSum(Arg1)}");
