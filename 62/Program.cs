// 62. В двумерном массиве n×k заменить четные элементы на противоположные по значению (a[i,j]=-a[i,j])

void PrintArray(double[,] matr)
{
        //обращение к первому значению массив[3]
    for (int i = 0; i < matr.GetLength(0); i++)
    {                              //обращение к первому значению массив[3]
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i,j]%2==0)
                matr[i,j]=-matr[i,j];
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