// 84. Определить являются ли введенные с клавиатуры символы правильной записью целого числа. Вычислить сумму цифр введенного числа

//1й вариант
/*
Console.WriteLine("Введите целое число");
string Digits = Console.ReadLine();
int temp = 0;
if (!Int32.TryParse(Digits, out temp))
    Console.WriteLine("Это не является верной записью целого");
else
{
    int sum = 0;
    foreach (char digit in Digits)
        sum += digit - 48;
    Console.WriteLine(sum);
}
*/
//2й вариант, позволяющий выйти за границы int32
Console.WriteLine("Введите целое число");
string number = Console.ReadLine();
int sum = 0;
for (int i = 0; i < number.Length; i++)
{
    if (char.IsDigit(number[i]))
    {
        sum += number[i] - 48;  //см. таблицу кодировок
    }
    else
    {
        // пропуск минуса в начале, если он есть
        if (i == 0 && number[i] == '-')
        {
            continue;
        }
        else
        {
            Console.WriteLine("Это не является верной записью целого");
            return;
        }
    }
}
Console.WriteLine("Сумма цифр числа: {0}", sum);