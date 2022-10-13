// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



double[,] CreateMatrixDoubleNum(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.NextDouble();
        }
    }
    return matrix;
}

void PrintMatrixDoubleNum(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{Math.Round(matrix[i, j], 2)}, ");
            else Console.Write($"{Math.Round(matrix[i, j], 2)}");
        }
        Console.WriteLine("|");
    }
}
double[,] array2D = CreateMatrixDoubleNum(3, 4);
PrintMatrixDoubleNum(array2D);
