// 82. C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки

// первый вариант через возвращение индекска к 0 до исключаемого символа
string? LineFromKeyboard=Console.ReadLine();
int textBefore = LineFromKeyboard.IndexOf('.');   
Console.WriteLine($"Количество символов в тексте = {textBefore}");
// второй через использование деления по длине строки до указанного символа
using System.Linq;
string LineFromKeyboard = Console.ReadLine();
int count = LineFromKeyboard.Split(".").First().Length; 
Console.WriteLine(count);

