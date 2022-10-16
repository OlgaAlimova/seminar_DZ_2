// Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] array2D1 = CreateMatrixRndInt(2, 3, 1, 3);
PrintMatrix(array2D1);
Console.WriteLine();
int[,] array2D2 = CreateMatrixRndInt(3, 2, 1, 3);
PrintMatrix(array2D2);
Console.WriteLine();
if (array2D1.GetLength(1) == array2D2.GetLength(0))
{
    int[,] productArray = ProductArray(array2D1, array2D2);
    PrintMatrix(productArray);
}
else Console.WriteLine("Произведение данных матриц невозможно");


int[,] ProductArray(int[,] arr1, int[,] arr2)
{
    int[,] matrix = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int n = 0; n < arr1.GetLength(1); n++)
            {
                matrix[i, j] = matrix[i, j] + arr1[i, n] * arr2[n, j];
            }
        }
    }
    return matrix;
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("|");
    }
}