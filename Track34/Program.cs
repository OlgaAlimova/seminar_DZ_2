// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.WriteLine("Введите размер массива: ");
int sizeTack = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное число диапазона массива: ");
int minTask = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное число диапазона массива: ");
int maxTask = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное число отрезка: ");
int minR = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное число отрезка: ");
int maxR = Convert.ToInt32(Console.ReadLine());

maxTask = maxTask + 1;

int[] CreateArrayRndInt(int size, int min, int max)
{
int[] array = new int[size];
var rnd = new Random();

for (int i = 0; i < size; i++)
{
array[i] = rnd.Next(min, max + 1);
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

int QuantRange(int[] array, int min, int max)
{
int counter = default;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= min && array[i] <= max) counter++;
}
return counter;
}

int[] arr = CreateArrayRndInt(sizeTack, minTask, maxTask);
PrintArray(arr);
int quanteRange = QuantRange(arr, minR, maxR);
Console.WriteLine(quanteRange);
