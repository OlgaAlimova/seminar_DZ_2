// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите индекс строки массива");
int a = Convert.ToInt32(Console.ReadLine());

Console. WriteLine("Введите индекс столбца массива");
int b = Convert.ToInt32(Console.ReadLine());

int m = 3;
int n = 4;
int[,] array2D = CreateMatrixRndInt(m, n, 1, 10);
CheckingValue(array2D);

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

void CheckingValue(int[,] matrix)
{
    if(a <= m && b <= n) Console.WriteLine($"{matrix[a, b]}");
    else Console.WriteLine("Такого элемента в массиве нет");
}
