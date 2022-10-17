// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int akkerman = Akkerman(numberM, numberN);
Console.WriteLine($"{akkerman}");



int Akkerman(int m, int n)
{
    int degree = Exponentiation((n + 3), (m - 2));
    int exponent = Exponentiation(2, degree) - 3;
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}


int Exponentiation(int num1, int num2)
{
    int exponent = 1;
    for (int i = 1; i <= num2; i++)
    {
        exponent = exponent * num1;
    }
    return exponent;
}


