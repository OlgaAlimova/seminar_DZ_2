// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива: ");
int sizeTack = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное число диапазона массива: ");
int minTask = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное число диапазона массива: ");
int maxTask = Convert.ToInt32(Console.ReadLine());

int minR = 100;
int maxR = 999;

// Console.WriteLine("Введите минимальное число отрезка: ");
// int minR = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите максимальное число отрезка: ");
// int maxR = Convert.ToInt32(Console.ReadLine());

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

int NumEvenNum(int[] array, int min, int max)
{
int counter = default;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= min && array[i] <= max && array[i] % 2 == 0) counter++;
}
return counter;
}

int[] arr = CreateArrayRndInt(sizeTack, minTask, maxTask);
PrintArray(arr);
int numEvenNum = NumEvenNum(arr, minR, maxR);
Console.WriteLine(numEvenNum);
