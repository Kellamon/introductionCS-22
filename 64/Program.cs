// 64. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты по значению.

void PrintArray(double[,] matr)
{
        //обращение к первому значению массив[3]
    for (int i = 0; i < matr.GetLength(0); i++)
    {                              //обращение ко второму значению массив[3]
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i,j]%2==0)
                matr[i,j]=matr[i,j]*matr[i,j];
            Console.Write($"{matr[i, j],3} ");
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