// 78.В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в».
// Покажите все слова (слова не обязательно осмысленные), состоящие из n букв, которые можно построить из букв этого алфавита

// вариант с лекции без рекурсии
char[] s = { 'а', 'и', 'с', 'в' };
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++) // для одной буквы
    for (int j = 0; j < count; j++) // для двух букв
        for (int k = 0; k < count; k++) // для трех букв
            Console.WriteLine($"{n++,-5} {s[i]},{s[j]},{s[k]}");

//вариант с лекции с рекурсией
int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}");
        return;
    }
    for (int i=0; i<alphabet.Length; i++)
    {
        word[length]= alphabet[i];
        FindWords(alphabet, word, length+1);
    }
}
FindWords("аисв", new char[5]);

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

//вариант с рекурсией

void ShowChars(string[] alphabet, int i = 0)
{
    if (i < alphabet.Length)
    {
        System.Console.Write($"{alphabet[i]}\t");
        ShowChars(alphabet, i + 1);
    }
}

void MakeWords(int charCount, int i = 1)
{
    if (i < charCount)
    {
        ShowChars;
    }
}

string[] simbols = { "а", "и", "с", "в" };
ShowChars(simbols);