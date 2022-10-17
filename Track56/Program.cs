// Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен
// наименьший элемент массива

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
int[,] arrayMin = MinElementSearch(array2D);
PrintMatrix(arrayMin);
int[,] delArray = DeliteRowColumn(arrayMin);
PrintMatrix(delArray);

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

int[] MinElementSearch(int[,] matrix)
{
    int[] minIndex = new int[1];
    int minIndexMatrix = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minIndexMatrix)
            {
                // 
                minIndex[0] = i;
                minIndex[1] = j;
                minIndexMatrix = matrix[i, j];
            }
        }
    }
    return minIndex;
}

int[,] DeliteRowColumn(int[,] matrix)
{
    int[] arr = MinElementSearch(matrix);
    int[,] newMatrix = new int [matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if(i != arr[0])
        {
            for (int j = 0; j < newMatrix.GetLength(1); j++)
            {
                if(j != arr[1]) newMatrix[i, j] = matrix[i, j];
            }
        }
    }
    return newMatrix;
}