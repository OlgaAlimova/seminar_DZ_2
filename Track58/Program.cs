// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
int[][] sumRows = RowsArrCreaty(array2D);
PrintMatrArr(sumRows);
Console.WriteLine();
int[] sumArr = SumArrCreaty(sumRows);
PrintArray(sumArr);
Console.WriteLine();
Console.WriteLine($"номер строки с наименьшим элементом = {MinRows(sumArr) + 1}");

int MinRows(int[] arr)
{
    int count = default;
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            count = i;
        }
    }
    return count;
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
    }
    return arrArr;
}

int[] SumArrCreaty(int[][] arr)
{
    int[] arrSum = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.Length; i++)
    {
        arrSum[i] = SumElementArr(arr[i]);
    }
    return arrSum;
}

int SumElementArr(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum = sum + arr[i];
    }
    return sum;
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

void PrintMatrArr(int[][] matrArr)
{
    for (int i = 0; i < matrArr.GetLength(0); i++)
    {
        Console.Write("|");
        PrintArray(matrArr[i]);
    }
}

