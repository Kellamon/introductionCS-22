// ABC=>CAB, ABC=>CBA получение новых строк

bool Test(string s1,string s2)
{
    s1 = s1.ToLower(); // для исключения ввода пользователем разного регистра
    s2 = s2.ToLower();
    if (s1.Length!=s2.Length) return false;
    char[] c1=s1.ToCharArray();
    char[] c2=s2.ToCharArray();
    Array.Sort(c1); // ABC
    Array.Sort(c2); // ABC
    s1= new String(c1);
    s2= new String(c2);
    return s1 == s2;
}
string s1 = "ABC";
string s2 = "BCA";

Console.WriteLine(Test(s1,s2));
