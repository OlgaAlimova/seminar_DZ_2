// Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
int[][] rowsArr = RowsArrCreaty(array2D);
PrintMatrArr(rowsArr);


int[] DecreasSort(int[] arr)
{
    int min = default;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] < arr[j]) 
            {
            min = arr[i];
            arr[i] = arr[j];
            arr[j] = min;
            }
        }
    }
    return arr;
}

int[][] RowsArrCreaty(int[,] matrix)
{
    int sizeRows = matrix.GetLength(0);
    int sizeColumns = matrix.GetLength(1);
    int[][] arrArr = new int[sizeRows][];

    for (int i = 0; i < sizeRows; i++)
    {
        int[] arrRows = new int[sizeColumns];
        for (int j = 0; j < sizeColumns; j++)
        {
            arrRows[j] = matrix[i, j];
        }
        arrArr[i] = arrRows;
        DecreasSort(arrArr[i]);
    }
    return arrArr;
}

void PrintMatrArr(int[][] matrArr)
{
    for (int i = 0; i < matrArr.GetLength(0); i++)
    {
        Console.Write("|");
        PrintArray(matrArr[i]);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
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




