// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] array3D = CreateMatrixRndInt(2, 2, 2, 10, 99);
Print3DMatrix(array3D);


int[,,] CreateMatrixRndInt(int n, int m, int p, int min, int max)
{
    int[,,] matrix = new int[n, m, p];
    int element = 11;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int k = 0; k < p; k++)
            {
                matrix[i, j, k] = element + 1;
                element = matrix[i, j, k];
            }
        }
    }
    return matrix;
}

void Print3DMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (k < matrix.GetLength(2) - 1) Console.Write($"{matrix[i, j, k],8} ({i}, {j}, {k}), ");
                else Console.Write($"{matrix[i, j, k],8} ({i}, {j}, {k})");
            }
            Console.WriteLine("|");
        }
    }
}