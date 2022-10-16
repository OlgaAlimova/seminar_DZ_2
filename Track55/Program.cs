// Составить частотный словарь элементов двумерного массива.
// Часточный словарь сожержит информацию о том, сколько раз встречается 
// элемент входных данных

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
int[] newArray = MatrixToOneRowArray(array2D);
PrintArray(newArray);
Console.WriteLine();
Array.Sort(newArray);
PrintArray(newArray);
Console.WriteLine();
СountingQuantity(newArray);


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

int[] MatrixToOneRowArray(int[,] matrix)
{
    int[] oneRowArray = new int[matrix.Length];
    int count = default;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            oneRowArray[count] = matrix[i, j];
            count++;
        }

    }
    return oneRowArray;
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

void СountingQuantity(int[] arr)
{
    int count = 1;
    int value = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (value == arr[i]) count++;
        else
        {
            Console.WriteLine($"значение {value} в массиве {count}");
            value = arr[i];
            count = 1;
        }
    }
    Console.WriteLine($"значение {value} в массиве {count}");
}