//20. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// добавлен пример использования подпрограммы 

// тип имя(аргументы)
int Part(double x, double y)
{
    //тело подпрограммы
    int part = 0;

    if (x > 0 && y > 0) part = 1;
    if (x < 0 && y > 0) part = 2;
    if (x < 0 && y < 0) part = 3;
    if (x > 0 && y < 0) part = 4;
    //System.Console.WriteLine("Part:" + part);   Вывод результатов в подпраграмме не допустим, если этого не требовалось
    return part;
}

// мое решение
/*
System.Console.WriteLine("Введите значение 'x'");
double x=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите значение 'y'");
double y=Convert.ToDouble(Console.ReadLine());
if (x>0)
{
    if (y>0)
    {
        System.Console.WriteLine("1я четверть");
    }
    else if (y<0) System.Console.WriteLine("4я четверть");
}
if (x<0)
{
    if (y<0)
    {
        System.Console.WriteLine("2я четверть");
    }
    else if (y>0) System.Console.WriteLine("3я четверть");
}
if (x==0) System.Console.WriteLine($"смотри условие задачи");
if (y==0) System.Console.WriteLine($"смотри условие задачи");
*/

//решение с урока
/*
System.Console.WriteLine("Введите значение 'x'");
double x = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите значение 'y'");
double y = Convert.ToDouble(Console.ReadLine());
int part = 0;

if (x > 0 && y > 0) part = 1;
if (x < 0 && y > 0) part = 2;
if (x < 0 && y < 0) part = 3;
if (x > 0 && y < 0) part = 4;
System.Console.WriteLine("Part:"+part);
*/

System.Console.WriteLine("Введите значение 'x'");
double x = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите значение 'y'");
double y = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Part:" + Part(x, y));