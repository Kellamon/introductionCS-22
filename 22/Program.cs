// 22. Программа проверяет пятизначное число на палиндромом.
System.Console.WriteLine("Введите целое пятизначное число");
string? P=(Console.ReadLine());
int length=P.Length;
string txtToCheck = P.Replace(" ","");
bool IsPalindrome()
{
    for (int i = 0; i < length/2; i++)
    {
        while (P[i]==P[length-1])
        {
            return true;
        }
    }
    return false;
}
if (IsPalindrome())
{
    System.Console.WriteLine($"{P} является палиндромом");
}
else System.Console.WriteLine($"{P} не является палиндромом");