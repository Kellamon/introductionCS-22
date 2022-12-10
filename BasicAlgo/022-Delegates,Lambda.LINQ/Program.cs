// Полсчитать сумму цифр.
//LINQ 
using System.Linq; //обычно она подключается по умолчанию

class Program
{
    static int CountChars(string s, Func<char, bool> isChar) // интегрированный и общераспространненый делегат
    {
        int count = 0;
        foreach (char c in s)
        {
            if (isChar(c))
            {
                count++;
            }
        }
        return count;
    }
    static bool IsLatin(char c)
    {
        return (c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z');
    }
    static bool isRus(char c)
    {
        return (c >= 'А' && c <= 'Я' || c >= 'а' && c <= 'я' || c == 'Ё' || c == 'ё');
    }
    static void Main()
    {
        
        string s = "123";
        //var это тип определяемый оператором.                                              пример метода расширения
        var queary = (from c in s where (c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z') select c).Count(); // пример использования Линк
                                                                                                            // Позволяет отобрать латиницу и превратить ее в массив
                                                                                                            // (или например посчитать и т.д.)
        var sum = (from c in s where char.IsDigit(c) select char.GetNumericValue(c)).Sum(); //получим массив числовых значений.
        Console.WriteLine(sum);
    }
}

//Делегаты
//позволяет например написать функцию, в которую будет передаваться какое то условие(делегат)
//который позволяет, например, заменить все ниже приведенные функцию на одну, которая будет выполнять проверку.
/*
int CountDigits(string s)
{
    int count = 0;
    foreach (char c in s)
    {
        if (char.IsDigit(c))
        {
            count++;
        }
    }
    return count;
}

int CountLatin(string s)
{
    int count = 0;
    foreach (char c in s)
    {
        if (c>='A' && c<='Z' || c>='a' && c<='z')
        {
            count++;
        }
    }
    return count;
}

int CountLatin(string s)
{
    int count = 0;
    foreach (char c in s)
    {
        if (c >= 'А' && c <= 'Я' || c >= 'а' && c <= 'я' || c=='Ё' || c=='ё')
        {
            count++;
        }
    }
    return count;
}
*/

//пример своего делегата
/*
//  тип значения / название делегата / в целом называется 
delegate bool IsChar(char c); //сигнатура функции(сигнатура bool(char)
class Program
{

    static int CountChars(string s,IsChar isChar)
    {
        int count = 0;
        foreach (char c in s)
        {
            if (isChar(c))
            {
                count++;
            }
        }
        return count;
    }
    static bool IsLatin(char c)
    {
        return (c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z');
    }
    static bool isRus(char c)
    {
        return (c >= 'А' && c <= 'Я' || c >= 'а' && c <= 'я' || c == 'Ё' || c == 'ё');
    }
    static void Main()
    {
        string s = "Эта строка содержит latinskie буквы и цифры(12345)";
        Console.WriteLine(CountChars(s, IsLatin));
        Console.WriteLine(CountChars(s, isRus));
        Console.WriteLine(s, char.IsDigit); // можно добавлять не обязательно созданный собой делегат
    }
}
//хороший пример использования делегатов: - это любой графический интерфейс. При вызове клавишей вызывается выбор делегатов, на которые обозначены какие то функции.
*/
//пример использования интегрированного делегата
/*
class Program
{
     static int CountChars(string s, Func<char, bool> isChar) // интегрированный и общераспространненый делегат
    {
        int count = 0;
        foreach (char c in s)
        {
            if (isChar(c))
            {
                count++;
            }
        }
        return count;
    }
    static bool IsLatin(char c)
    {
        return (c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z');
    }
    static bool isRus(char c)
    {
        return (c >= 'А' && c <= 'Я' || c >= 'а' && c <= 'я' || c == 'Ё' || c == 'ё');
    }
    static void Main()
    {
        string s = "Эта строка содержит latinskie буквы и цифры(12345)";
        Console.WriteLine(CountChars(s, IsLatin));
        Console.WriteLine(CountChars(s, isRus));
        Console.WriteLine(s, char.IsDigit); // можно добавлять не обязательно созданный собой делегат
    }
}
*/
//=> Лямбда выражения
//пример
/*
class Program
{
    static int CountChars(string s, Func<char, bool> isChar) // интегрированный и общераспространненый делегат
    {
        int count = 0;
        foreach (char c in s)
        {
            if (isChar(c))
            {
                count++;
            }
        }
        return count;
    }
    static bool IsLatin(char c)
    {
        return (c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z');
    }
    static bool isRus(char c)
    {
        return (c >= 'А' && c <= 'Я' || c >= 'а' && c <= 'я' || c == 'Ё' || c == 'ё');
    }
    static void Main()
    {
        string s = "Эта строка содержит latinskie буквы и цифры(12345)";
        Console.WriteLine(CountChars(s, IsLatin));
        Console.WriteLine(CountChars(s,
            delegate (char c)  // анонимный делегат, позволяет описать какую то функцию одноразово(например если она нужна только в одном месте)
            {
                return (c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z');
            }
            ));
        Console.WriteLine(CountChars(s,
            (c) =>  // лямбда выражение(дальнейшее упрощение программистов) которая по сути, позволяет сократить запись анонимного делегата. Многострочное.
            {
                return (c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z');
            }
            ));
        Console.WriteLine(CountChars(s,
            (c) => c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z' // лямбда выражение однострочное
            ));
        Console.WriteLine(CountChars(s, isRus));
        Console.WriteLine(s, char.IsDigit); // можно добавлять не обязательно созданный собой делегат
    }
}
*/
