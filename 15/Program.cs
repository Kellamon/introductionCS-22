// 15.С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).

Console.Write("Введи число: ");
int A = Convert.ToInt32(Console.ReadLine());
string AT = Convert.ToString(A);
if (AT.Length > 2)
{
  Console.WriteLine("третья цифра: " + AT[2]);
}
else 
{
  Console.WriteLine("NO");
}