// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = DegreeNumber(A, B);
Console.WriteLine($"число {A} в степени {B} = {result}");

int DegreeNumber(int num1, int num2)
{
    if (num2 == 0) return 1;
    int res = num1;
    res *= DegreeNumber(num1, num2 - 1);
    return res;
}

