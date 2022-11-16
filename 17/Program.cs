// 17. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
System.Console.WriteLine("Введите число от 1 до 7");
int a=Convert.ToInt32(Console.ReadLine());
if (a==1) System.Console.WriteLine("Сегондя Понедельник");
if (a==2) System.Console.WriteLine("Сегондя Вторник");
if (a==3) System.Console.WriteLine("Сегондя Среда");
if (a==4) System.Console.WriteLine("Сегондя Четверг");
if (a==5) System.Console.WriteLine("Сегондя Пятница");
if (a==6) System.Console.WriteLine("Сегондя Суббота, а значит выходной!");
if (a==7) System.Console.WriteLine("Сегондя Воскресенье, а значит выходной!");
if (a>7) System.Console.WriteLine("Не шали, просили от 1 до 7");