// 5. С клавиатуры вводятся три числа. Найти максимальное из трех чисел

int a;
int b;
int c;
int max;
System.Console.Write("Введите число a= ");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
System.Console.Write("Введите число b= ");
string? v=Console.ReadLine();
b=Convert.ToInt32(v);
System.Console.Write("Введите число c= ");
string? j=Console.ReadLine();
c=Convert.ToInt32(j);
max = a;
if (b > a)
    max = b;
if (c > max)
    max = c;
System.Console.WriteLine(max + "является максимальным");    


     
