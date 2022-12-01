// 61. Показать двумерный массив размером m×n заполненный вещественными случайными числами

void PrintArray(double[,] matr)
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

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j]=new Random().Next(1,10);// [1;10]
        }
    }
}
double[,] matrix = new double[3, 4];
FillArray(matrix);
PrintArray(matrix);