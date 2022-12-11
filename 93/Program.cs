//// Задача 93: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, заданы 2 массива:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//и
//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7
//Их произведение будет равно следующему массиву:
//1 20 56 10
//20 81 8 6
//56 8 4 24
//10 6 24 49

int[,] RandomMatrix(int Row, int Colum, int min, int max)
{
    int[,] array = new int[Row, Colum];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max+1);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ProductMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] product = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            product[i,j] = matrix1[i, j] * matrix2[i,j];
        }
    }
    return product;
}

int Row = 4;
int Colum = ;
int[,] matrix1 = RandomMatrix(Row, Colum, 2, 6);
int[,] matrix2 = RandomMatrix(Row,Colum, 2, 6);
int[,] product = ProductMatrix(matrix1, matrix2);
Print2DArray(matrix1);
Console.WriteLine();
Print2DArray(matrix2);
Console.WriteLine();    
Print2DArray(product);