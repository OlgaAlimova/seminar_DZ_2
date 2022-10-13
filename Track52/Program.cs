// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = 3;
int n = 4;
int[,] array2D = CreateMatrixRndInt(m, n, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();
double[] createSumArray = CreateSumArray(array2D);
PrintMatrixDouble(createSumArray);

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

double[] CreateSumArray(int[,] matrix)
{
    double[] matrixMaele = new double[4];
    double sum = 0;
    double sizeMatrix = matrix.GetLength(0);
    for (int j = 0; j < 4; j++)
    {
        for (int i = 0; i < sizeMatrix; i++)
        {
            sum += matrix[i, j];
        }
        matrixMaele[j] = sum / sizeMatrix;
    }
    return matrixMaele;
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

void PrintMatrixDouble(double[] array)
{
    Console.Write("|");
    for (int j = 0; j < array.Length; j++)
    {
        if (j < array.Length - 1) Console.Write($"{Math.Round(array[j], 2),4}, ");
        else Console.Write($"{Math.Round(array[j], 2),4}");
    }
    Console.WriteLine("|");
}

