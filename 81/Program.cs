// 81. 81. Вывести на экран символы от A до Z как показано ниже: 
// А
// BB
// CCC
// ...

for (char c = 'A'; c <='Z';c++)
{
    for (int i=1;i<=c-'A' +1; i++)
        Console.Write(c);
    Console.WriteLine();
}
