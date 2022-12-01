// 60. Показать двумерный массив размером m×n заполненный целыми случайными числами

void PrintArray(int[,] matr)
{
        //обращение к первому значению массив[3]
    for (int i = 0; i < matr.GetLength(0); i++)

    {                              //обращение к первому значению массив[3]
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();   // для создания разграничивания
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j]=new Random().Next(1,10);// [1;10]
        }
    }
}
int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);