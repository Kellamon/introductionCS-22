// С клавиатуры вводя два числа a и b. Найти максимальное из них.

int a;
int b;
System.Console.Write("Введите число a= ");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
System.Console.Write("Введите число b= ");
string? v=Console.ReadLine();
b=Convert.ToInt32(v);
if (a>b)
{
    System.Console.WriteLine(a + "является максимальным");
}
else
{
    System.Console.WriteLine(b + "является максимальным");
}