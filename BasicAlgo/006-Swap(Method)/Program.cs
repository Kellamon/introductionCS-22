// 

void Swap(ref int a,ref int b) // reference-ccылка 
{
    int t=a;
    a=b;
    b=t;
}

void Calculator(int a, int b, out int sum, out int multi) // используется как и реф, но позволяет не присваивать значение
{
    sum=a+b;
    multi=a*b;
}
int a=3, b=5;

System.Console.WriteLine($"a={a} b={b}");
Swap(ref a,ref b);
System.Console.WriteLine($"a={a} b={b}");
int sum=0, multi=0;
Calculator(a,b, out sum, out multi);