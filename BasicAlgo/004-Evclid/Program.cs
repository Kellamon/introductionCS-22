// Алгорит Эвклида

int k = 0;
int GCD(int a, int b)
{
    while (a != b)
    {
        k++;
        if (a > b)
            a = a - b;
        else
            b = b - a;
    }
    return a;
}


int quickGCD(int a, int b)
{
    while (a != 0 && b != 0)
    {
        k++;
        if (a > b)
            a = a % b;
        else
            b = b % a;
    }
    return a+b;
}

System.Console.WriteLine(GCD(15, 5000)); //простой алгоритм Эвклида
System.Console.WriteLine(k);
k=0;
System.Console.WriteLine(quickGCD(15, 5000)); //ускоренный алгоритм Эвклида
System.Console.WriteLine(k);