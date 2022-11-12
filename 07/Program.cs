// 7. Выяснить является ли число чётным

Console.Write("введите число: ");
int a=Convert.ToInt32(Console.ReadLine());
if (a % 2==1)
{
    Console.WriteLine("число нечетное");         
}
else
{
    Console.WriteLine("Число четное");
}