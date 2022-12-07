// 83. Подсчитать количество цифр среди вводимых с клавиатуры символов

string s=Console.ReadLine();
int k = 0;
//for (int i=0; i<s.Length; i++)   // первый вариант
//    if (char.IsDigit(s[i])) k++;
foreach(char c in s)  // второй вариант (foreach каждый элемент в массиве)
    if (char.IsDigit(c)) k++;
Console.WriteLine(k);