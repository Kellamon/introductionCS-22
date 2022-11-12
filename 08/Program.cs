// 8. Вывести на экран числа от -N до N
System.Console.WriteLine("Введите число -N ");
int N=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число n ");
int n=Convert.ToInt32(Console.ReadLine());
int i=0;
while (i>=N)
{
    System.Console.Write($"{i} ");
    i=i-1;
}
int j = 1;
while (j<=n)
{
    System.Console.Write($"{j} ");
    j++;
}