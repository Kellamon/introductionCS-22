// 78.В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в».
// Покажите все слова (слова не обязательно осмысленные), состоящие из n букв, которые можно построить из букв этого алфавита

// вариант без рекурсии
Console.WriteLine("Ведите букавкИ");
var letters = Console.ReadLine().ToCharArray(); // Ввод букв
Console.WriteLine("Попробуйте ввести циферки, которые, вероятно, будут обозначать длину слова");
var wordLength = int.Parse(Console.ReadLine()); // Ввод размера слова

var word = new char[wordLength];
var totalWordsCount = 1;

for (var i = 0; i < wordLength; i++)
    totalWordsCount *= letters.Length;

for (var i = 0; i < totalWordsCount; i++)
{
    var accum = i;
    for (var j = word.Length - 1; j >= 0; j--)
    {
        word[j] = letters[accum % letters.Length];
        accum /= letters.Length;
    }

    Console.WriteLine(new string(word));
}