// 52. Написать программу преобразования десятичного числа в двоичное
// без подрограммы
/*int n=10; //при 0 ответа не будет
string s="";
if(n==0)
    s="0";
while (n!=0)
{
    //System.Console.WriteLine(n%2); можно заменить на
    s=Convert.ToString(n%2)+s;
    n /=2;
}
System.Console.WriteLine();
System.Console.WriteLine(s);*/

// с подпрограммой
string DecimalToBin(int n)
{
    string s = "";
    if (n == 0)
        return "0";
    while (n != 0)
    {
        //System.Console.WriteLine(n%2); можно заменить на
        s = Convert.ToString(n % 2) + s;
        n /= 2;
    }
    return s;
}

System.Console.WriteLine();
System.Console.WriteLine(DecimalToBin(7));