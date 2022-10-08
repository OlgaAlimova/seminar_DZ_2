// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// k1 * x + b1 = k2 * x + b2; k1 * x - k2 * x = b2 - b1; x = (b2 - b1)/(k1 - k2)
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите число b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

void Peresechenie (int a1, int n1, int a2, int n2)
{
    double c = (a2 - a1)/(n1 - n2); //2/-4 = -0.5
    double z = (n1 * c) + a1; //5*-0.5+2 = -0.5
    Console.WriteLine($"({c}; {z})");
}

Peresechenie(b1, k1, b2, k2);
