// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine("Введите число, проверку которого нужно сделать: ");
int exc = Convert.ToInt32(Console.ReadLine());

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

bool CheckNumber(int[] array, int arg)
{
    bool checkNumber = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == arg)
        {
            checkNumber = true;
            break;
        }
    }
    return checkNumber;
}

int[] arr = CreateArrayRndInt(sizeTack, minTask, maxTask);
PrintArray(arr);
bool checkNumber = CheckNumber(arr, exc);

if(checkNumber == true) Console.WriteLine("да");
else Console.WriteLine("нет");
