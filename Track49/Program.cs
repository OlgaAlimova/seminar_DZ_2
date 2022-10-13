// Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

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

int MatrixSumDiagonal(int[,] matrix)
{
    int sum = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) sum = sum + matrix[i, j];
        }
    }
    return sum;
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

int[,] array2D = CreateMatrixRndInt(5, 3, 1, 10);
PrintMatrix(array2D);
int sumElementDiagonal = MatrixSumDiagonal(array2D);
Console.WriteLine($"сумма элементов диагонали = {sumElementDiagonal}");

// / метод возведение чётных элементов массива в квадрат
// void GetSquareEvenElem(int[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i+=2) //rows (0)
// {
// for (int j = 0; j < matrix.GetLength(1); j+=2) //columns (1)
// {
// matrix[i, j] *= matrix[i, j];
// }
// }
// }

// int SummOfEqualIndex(int[,] matrix)
// {
// int sum = default;
// int targetSize = 0;
// if ( matrix.GetLength(0) > matrix.GetLength(1)) targetSize = 1;
// for (int i = 0; i < matrix.GetLength(targetSize); i++)
// {
// sum += matrix[i, i];
// }
// return sum;
// }