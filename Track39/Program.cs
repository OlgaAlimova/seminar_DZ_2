// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

Console.WriteLine("Введите размер массива: ");
int sizeTask = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное число диапазона массива: ");
int minTask = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное число диапазона массива: ");
int maxTask = Convert.ToInt32(Console.ReadLine());

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

void ReverseArray(int[] array)
{
    int size = array.Length;
    int index1 = 0;
    int index2 = size -1;

    while(index1 < index2)
    {
        int obj = array[index1];
        array[index1] = array[index2];
        array[index2] = obj;

        index1++;
        index2--;
    }
}

int[] arr = CreateArrayRndInt(sizeTask, minTask, maxTask);
PrintArray(arr);
ReverseArray(arr);
PrintArray(arr);

// 2 вариант решения

// void ReverseArray2(int[] array)
// {
// int size = array.Length;
// for (int i = 0; i < size / 2; i++)
// {
// Swap(array, i, array.Length - 1 - i);
// }
// }

// void Swap(int[] array, int index1, int index2)
// {
// int temp = array[index1];
// array[index1] = array[index2];
// array[index2] = temp;
// }