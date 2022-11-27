// 54. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1

Console.Write("Введите числа через запятую: ");
int[] numbers = StringToNum(Console.ReadLine());
PrintArray(numbers);
System.Console.WriteLine();
SelectSort(numbers);
PrintArray(numbers);
System.Console.WriteLine();

int[] f = SelectSort(numbers);
f[0] = 0;
f[1] = 1;
for (int i = 2; i < numbers.Length; ++i) 
{
    f[i] = f[i - 1] + f[i - 2];
    Console.WriteLine("F{0}) {1}", i);
}
/*int n_1 = 1;
int n_2 = 1;
 
for (int i = 3; i <= n; ++i)
{
    var n_3 = n_1 + n_2;
    Console.WriteLine("F{0}) {1}", i, n_3);
    n_1 = n_2;
    n_2 = n_3;
}*/

int[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int[count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input[i] != ',')
        {
            if (i != input.Length - 1)
            {
                temp += input[i].ToString();
                i++;
            }
            else
            {
                temp += input[i].ToString();
                break;
            }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}

void Swap(ref int a, ref int b)
{
    int t = a;
    a = b;
    b = t;
}

int[] SelectSort(int[] numbers)
{
    int im;
    for (int i = 0; i < numbers.Length; i++)
    {
        im = i;
        for (int j = i + 1; j < numbers.Length; j++)
        {
            if (numbers[im] > numbers[j]) im = j;
        }
        Swap(ref numbers[i], ref numbers[im]);
    }
    return numbers;
}