
// пример поиска информации в указанной папке без рекурсии
/*
string path = "C:\\Users\\badze\\OneDrive\\Рабочий стол\\Учеба\\git\\Examples.DYV\\Example_HelloConsole";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();
for (int i = 0; i< fi.Length; i++)
{
    Console.WriteLine(fi[i].Name);
}
*/

//пример с рекурсией
/*
void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }
    FileInfo[] files = catalog.GetFiles();
    for(int i=0; i<files.Length; i++)
    {
        Console.WriteLine($"{indent} {files[i].Name}");
    }
}
string path = @"C:\Users\badze\OneDrive\Рабочий стол\Учеба\git\Examples.DYV\Example003_sum";
CatalogInfo(path);
*/

//Игра в пирамидки(алгоритм для нахождения правильного решения)
/*
void Towers(string with ="1", string on = "3", string some = "2", int count =4)
{
    if (count >1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count >1) Towers(some, on, with, count -1);
}
Towers();
*/

//Решение некоторых задач. Обход разных структур
/*
string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
//                  0    1    2    3     4    5   6    7    8    9    10   11     дерево последовательности от родительского к дочерним

void InOrderTraversal(int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if (left<tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.WriteLine(tree[pos]); // влияет на вид(преордер инордер и т.д.
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}
InOrderTraversal();
*/

//Пример оформления программы, что бы ее можно было запустить через cmd или exe в папке bin
class Program
{
    static public void Main(string[] args)
    {
        if(args.Length >= 1)
        {
            if (args[0] = "")
                Console.WriteLine($"Hello, {args[0].Replace("-", "")}!");
        }
        Console.ReadKey();
    }
}
