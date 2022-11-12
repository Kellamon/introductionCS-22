// 14.С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.
System.Console.WriteLine("Ввод а: ");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Ввод b: ");
double b=Convert.ToDouble(Console.ReadLine());

if (a%b==0)
{
    System.Console.WriteLine("Число а кратно b");
}
else Console.WriteLine("остаток от деления "+(a%b));