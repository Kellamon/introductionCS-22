// 12. С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа
System.Console.WriteLine("Введите число от 10 до 99");
int c=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(c/10%10);

