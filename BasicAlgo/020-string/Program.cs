string s = "asdf"; // указываем строки. Стринг это класс. ссылочный тип данных
//immutable string (не изменяемые строки)
Console.WriteLine(s[0]);
for (int i = 0; i < s.Length; i++)
    Console.WriteLine(s[i]);
//s[0] = 'S'; позволяло бы изменить первый элемент на S, но в с# не работает
char[] cc = s.ToCharArray(); //используем для замены строки. Переводим в символы и обратно.
cc[0] = 'S';
s = new String(cc);

System.Text.StringBuilder sb = new System.Text.StringBuilder("asda"); // позволяет ускорить работу со строками. Для изменнения строк
sb[0] = 's';
s = sb.ToString();

//for (int i = 0; i < 100000; i++)
//    s = s + "1"; // создается новая стркоа! Существенная нагрузка на ЦП.
for (int i = 0; i < 100000; i++)
    sb.Append("1");

string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 == s2);
Console.WriteLine(s1.CompareTo(s2));
Console.WriteLine(String.Compare(s1, 2, s2, 3, 4, true));

// s1.Length позволяет работать с длинной строки
// s2 = s1.Substring(2, 4); вырезаем часть строки
// Console.WriteLine(s1.Indexof("as"));
// s2=s1.Replace('a','b'); позволяет изменить символы

Random random1 = new Random(100);
Random random2 = new Random(100);
random2 = random1;
Console.WriteLine(random2 == random1);

//ReadLn(a,b,c) пример введения на паскале
//10 20 30
// пример введения на с#
//1 пример
/*
string s=Console.ReadLine();
string[] ss=s.Split(' ');
int[] n=new int[ss.Length];
for (int i=0; i<ss.Length; i++)\
        n[i] = Convert.ToInt32(ss[i]);
int a = n[0];
int b = n[1];
int c = n[2];
*/
//2 пример
string s = Console.ReadLine().Split(' ');
int[] n=Array.ConvertAll<string, int>(ss, Convert.ToInt32); // обобщенные типы и параметризированные методы
int a = n[0];
int b = n[1];
int c = n[2];

