// 15.С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).

Console.Write("Введи число: ");
int A = Convert.ToInt32(Console.ReadLine());
A=Math.Abs(A); // позволяет использовать отрицательные знаечния путем вывода в моудль и отбрасывания знака
// 1 вариант
/*string AT = Convert.ToString(A);
if (AT.Length > 2)
{
  Console.WriteLine("третья цифра: " + AT[2]);
}
else 
{
  Console.WriteLine("NO");
}*/
// вариант 2 выводим третью цифру(123546->3)
if (A>99)
{
   while (A>1000)
   {
      A=A/10;
   }
   System.Console.WriteLine(A%10);
}
else
{
  System.Console.WriteLine("NO");
}