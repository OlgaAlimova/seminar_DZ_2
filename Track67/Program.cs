// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
SwapPlaces(numberM, numberN);

void SwapPlaces(int m, int n)
{
    if (n < m)
    {
        int t = default;
        t = n;
        n = m;
        m = t;
    }

}

int resultSum = SumNaturalNumbersFromMToN(numberM, numberN);
Console.WriteLine(resultSum);

int SumNaturalNumbersFromMToN(int m, int n)
{   
        if (m == n) return n;
        if (m == (n + 1)) return m + n;
        int sum = m + n;
        if (m < n) sum += SumNaturalNumbersFromMToN((m + 1), (n - 1));
        m++;
        n--;
        return sum;
        
}

