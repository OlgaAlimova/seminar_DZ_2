// Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементом массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine("Введите размер массива: ");
int sizeTack = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное число диапазона массива: ");
int minTask = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное число диапазона массива: ");
int maxTask = Convert.ToInt32(Console.ReadLine());

maxTask = maxTask + 1;

double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] array = new double[size];

    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min;
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}


double DifferenceNumber(double[] array)
{
    
    double maxDif = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxDif) maxDif = array[i];
    }
    
    double minDif = array[0];
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] < minDif) minDif = array[j];
    }

    double dif = (maxDif - minDif);
    Console.WriteLine(maxDif);
    Console.WriteLine(minDif);
    return dif;
}

double[] arr = CreateArrayRndInt(sizeTack, minTask, maxTask);
PrintArray(arr);
double differenceNumber = DifferenceNumber(arr);
Console.WriteLine(differenceNumber);
