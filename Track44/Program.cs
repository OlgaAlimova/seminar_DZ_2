// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Сколько чисел Вы хотите ввести? ");
int num = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArray(num);
PrintArray(arr);
Console.WriteLine($"{PlusNum(arr)}");

int[] CreateArray(int number)
{
    int j = 0;
    int[] array = new int[number];
    while (j < array.Length)
    {
        Console.WriteLine($"Введите число {j}: ");
        array[j] = Convert.ToInt32(Console.ReadLine());
        j++;
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

int PlusNum(int[] array)
{
    int count = 0;
    for (int n = 0; n < array.Length; n++)
    {
        if (array[n] > 0) count++;
    }
    return count;

}




