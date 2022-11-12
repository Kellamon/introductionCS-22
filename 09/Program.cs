// Вывести на экран четные числа от 1 до N
// работает, можно коммитить
int N=Convert.ToInt32(Console.ReadLine());
int i=1;
while (i<=N)
{
    System.Console.Write($"{i} ");
    i=i+2;
}
System.Console.WriteLine();
for (int j = 2; j <=N; j=j+2)
{
    System.Console.Write($"{j} ");
}