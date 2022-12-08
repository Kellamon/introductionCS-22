// 88. Заменить все вхождения подстроки w в строке st на строку v. Вывести на экран первоначальную строку и конечную строку
//не нашел вариант решения.

Console.WriteLine("Введите строку st");
string st = Console.ReadLine();
Console.WriteLine("Введите строку w");
string w = Console.ReadLine();
Console.WriteLine("Введите строку v");
string v = Console.ReadLine();
st.Replace(w, v);
Console.WriteLine("Измененная строка s: {0}", st);

/*
static void Main(string[] args)
{
    Console.WriteLine("Введите строку st");
    string st = Console.ReadLine();
    Console.WriteLine("Введите строку w");
    string w = Console.ReadLine();
    Console.WriteLine("Введите строку v");
    string v = Console.ReadLine();
    string[] a = st.ToString().Split(' ');
    string[] b = w.ToString().Split(' ');
    string[] c = v.ToString().Split(' ');
    Console.WriteLine(a);
    for (int i = 0; i < a.Length; i++)
    {
        for (int j = 0; j < b.Length; j++)
        {
            if (a[i] = b[j])
            {
                for (int x = 0; x < c.Length; x++)
                {
                    a[i] = a[i].Replace(b[j], c[x]);
                    Console.WriteLine("Новая строка: ", a);
                }
            }
        }
    }
    Console.ReadKey(true);
}
*/