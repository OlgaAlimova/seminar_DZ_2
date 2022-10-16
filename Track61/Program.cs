// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] array2D = CreateMatrixRndInt(4, 4);
PrintMatrix(array2D);
Console.WriteLine();


int[,] CreateMatrixRndInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int rowsEnd = matrix.GetLength(0) - 1; //3
    int columnsEnd = matrix.GetLength(1) - 1; //3
    int n = 0;
    int m = 1;
    int lastRows = default;
    int lastColumns = default;

    matrix[n, m - 1] = 01; // [0,0]

    while (n <= rows / 2 + 1 && m <= columns / 2) // 0 <= 3 && 0 <= 2 | 1 <= 3 && 1 <= 2
    {

        for (int j = m; j <= rowsEnd; j++) // j = 1, j <= 3 | j = 2 j<=2
        {
            matrix[n, j] = matrix[n, j - 1] + 1; // [0,1] = [0, 0] + 1 = 2; [0,2] = [0,1] + 1 = 3; [0,3] = [0,2] + 1 = 4 | [1,2] = [1,1] + 1 = 14
        }
        for (int i = n + 1; i <= columnsEnd; i++) // i = 1, i <= 3 | i = 2, i <= 2
        {
            matrix[i, columnsEnd] = matrix[i - 1, columnsEnd] + 1; // [1, 3] = [0,3] + 1 = 5; [2,3] = [1,3] + 1 = 6; [3,3] = [2,3] + 1 = 7 | [2,2] = [1,2] + 1 = 15
        }
        for (lastColumns = columnsEnd - 1; lastColumns >= (m - 1); lastColumns--) // от 2 до 0 | от 1 до 1
        {
            matrix[rowsEnd, lastColumns] = matrix[rowsEnd, lastColumns + 1] + 1; // [3,2] = [3,3] + 1 = 8; [3,1] = [3,2] + 1 = 9; [3, 0] = [3,1] + 1 = 10 | [2,1] = [2,2] + 1 = 16
        }
        for (lastRows = rowsEnd - 1; lastRows > n; lastRows--) // от 2 до 1 | не выполняется
        {
            matrix[lastRows, m - 1] = matrix[lastRows + 1, m - 1] + 1; // [2,0] = [3,0] + 1 = 11; [1,0] = [2,0] + 1 = 12; 
        }
        n++; // 1 | 2
        m++; // 2 | 3
        if(m < matrix.GetLength(1)/2+1)
        {
        matrix[n, m-1] = matrix[n, m - 2] + 1; // [1,1] = [1,0] + 1 = 13;
        }
        rowsEnd = rowsEnd - 1; // 2
        columnsEnd = columnsEnd - 1; // 2




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