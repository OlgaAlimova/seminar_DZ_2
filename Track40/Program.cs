// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите число a: ");
int sideTriagleA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int sideTriagleB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число c: ");
int sideTriagleC = Convert.ToInt32(Console.ReadLine());

// if (a < (b + c) && b < (a + c) && c < (a + b)) Console.WriteLine("такой треугольник может существовать");
// else Console.WriteLine("такой треугольник существовать не может");

bool ExistenceTriagle(int sideA, int sideB, int sideC)
{
    return sideA < sideB + sideC && sideB < sideA + sideC && sideC < sideA + sideB;
}

if (ExistenceTriagle (sideTriagleA, sideTriagleB, sideTriagleC)) Console.WriteLine("такой треугольник может существовать");
else Console.WriteLine("такой треугольник существовать не может");
