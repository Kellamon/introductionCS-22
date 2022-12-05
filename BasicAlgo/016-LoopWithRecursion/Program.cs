﻿// Вывести числа от 1 до N без использования цикла

// пример с использованием goto(использовать в С# его крайне не рекомендуется)
/*
int = 1;
int N = 10;
metka:
Console.WriteLine(i);
i++;
if (if<= N) goto metka;
*/

// пример с рекурсией

void Loop(int N, int i)
{
    if (i<=N)
    {
        System.Console.WriteLine(i);
        Loop(N, i + 1);  //Рекурсией называется вызов подрограммы в самой подпрограмме(ПРИМЕР!!!!)
    }   
}
Loop(10, 1);
