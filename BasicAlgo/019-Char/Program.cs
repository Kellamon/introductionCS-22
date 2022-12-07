// Изучаем тип Char

char c = 'a'; // указываем символ char - структура
// с = '\x0064'; //код символа
// c = '\u0064'; //код символа в юникод обязательно с 00
char b = 'a'; // если например сделать с + b то получим число, так как он берет код символа
Console.WriteLine(c.ToString()+b.ToString()); // позволяет склеить буквы
Console.WriteLine((int)b); // позволяет увидеть числовой код символа

if (b >= '0' && b <= '9') Console.WriteLine("It's Digit");
if (b >= 'A' && b<= 'Z') Console.WriteLine("It's big Latin");
if (b>='a' && b<='z' || b>='A' && b<='Z') Console.WriteLine("It's big Latin")

if (Char.IsDigit(b)) Console.WriteLine("It's digit");


