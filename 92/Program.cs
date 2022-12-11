// 92. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).


int[,] RandomMatrix(int Row, int Colum, int min, int max)
{
    int[,] array = new int[Row, Colum];
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0; j<array.GetLength(1);j++) 
        {
            array[i,j] = new Random().Next(min, max);   
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MatrixToMatrix(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=i; j<array.GetLength(1); j++) 
        {
            int temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;
        }
    }
}



int[,] matrix = RandomMatrix(4, 5, 0, 99);
Print2DArray(matrix);
System.Console.WriteLine();
if (matrix.GetLength(0) == matrix.GetLength(1))
{
    MatrixToMatrix(matrix);
    Print2DArray(matrix);
}
else Console.WriteLine($"Матрица не является квадратной, попробуйте изменить введеные значения." + "\n");


