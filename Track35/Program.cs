// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.WriteLine("Введите размер массива: ");
int sizeTack = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное число диапазона массива: ");
int minTask = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное число диапазона массива: ");
int maxTask = Convert.ToInt32(Console.ReadLine());

maxTask = maxTask + 1;

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    // double[] array = new double[size];

    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
        // array[i] = rnd.NextDouble() * (max - min) + min; получим массив вещественных чисел в диапазоне min - max
    }
    return array;
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

int[] ProductPairsNumber(int[] array)
{
    int lengthNewAr = default;
    if (array.Length % 2 == 0) lengthNewAr = array.Length / 2;
    else lengthNewAr = (array.Length / 2) + 1;
    int[] newArray = new int[lengthNewAr];

    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = array[i] * (array[array.Length - i - 1]);
    }
    if (array.Length % 2 == 1) newArray[newArray.Length - 1] = array[array.Length / 2];
    return newArray;
}

int[] arr = CreateArrayRndInt(sizeTack, minTask, maxTask);
PrintArray(arr);
int[] prodPairsNum = ProductPairsNumber(arr);
PrintArray(prodPairsNum);
