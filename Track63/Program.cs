// Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("Введите первое число");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberN = Convert.ToInt32(Console.ReadLine());
NaturalNumbersFromMToN(numberM, numberN);

void NaturalNumbersFromMToN(int numM, int numN)
{
if (numM < numN)
{
Console.Write($"{numM} ");
NaturalNumbersFromMToN(numM + 1, numN);


}
if (numM > numN)
{
Console.Write($"{numM} ");
NaturalNumbersFromMToN(numM - 1, numN);
}
if (numN == numM) Console.Write($"{numM} ");
}