// //94. задача. Составить частотный словарь элементов одномерного массива состоящих из чисел от 0 до 99

int[] data = { 1, 3, 4, 8, 3, 5, 8 };
int[] freqArr = new int[100];
//пример без словаря
/*
foreach(int element in data)
    freqArr[element]++;

for (int i = 0; i < freqArr.Length; i++)
    if (freqArr[i]!=0)
    Console.WriteLine($"{i} {freqArr[i]}");
*/
//пример со словарем
// добавляем словарь, который существенно увеличивает возможности, уменьшая нагрузку.
Dictionary<int, int> frecDic = new Dictionary<int, int>();
foreach (int element in data)
    if (frecDic.ContainsKey(element)) frecDic[element]++;
    else frecDic.Add(element, 1);
foreach (var el in frecDic)
    Console.WriteLine($"{el.Key} {el.Value}");
