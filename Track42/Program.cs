// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

void PrintFibonachi(int num)
{
    int firstNum = 0;
    int secondNum = 1;
    Console.WriteLine($"{firstNum} ");
    Console.WriteLine($"{secondNum} ");
    for (int i = 2; i < num; i++)
    {
        int nextNum = firstNum + secondNum;
        Console.WriteLine($"{nextNum} ");
        firstNum = secondNum;
        secondNum = nextNum;
        //Console.WriteLine(" ");
    }
}

PrintFibonachi(number);

// int[] array = new int[5];
// CreateFibonacciRow(array);
// PrintArray(array);

// void CreateFibonacciRow (int[] arr)
// {
// arr[0] = 0;
// arr[1] = 1;
// for (int i = 2; i < arr.Length; i++)
// {
// arr[i] = arr[i - 1] + arr[i - 2];
// }
// }
