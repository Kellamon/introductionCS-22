//20. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

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
