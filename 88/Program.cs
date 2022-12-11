// 88. Заменить все вхождения подстроки w в строке st на строку v. Вывести на экран первоначальную строку и конечную строку
//не нашел вариант решения.

Console.WriteLine("Введите строку st");
string st = Console.ReadLine();
Console.WriteLine("Введите строку w");
string w = Console.ReadLine();
Console.WriteLine("Введите строку v");
string v = Console.ReadLine();
st = st.Replace(w, v);
Console.WriteLine($"Измененная строка s: {st}", );
