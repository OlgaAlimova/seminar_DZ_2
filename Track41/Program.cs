// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int binaryNum = ConvertNumberToBinary(number);
Console.WriteLine($"{number} -> {binaryNum}");
int ConvertNumberToBinary (int num)
{
int binaryNum = 0;
int count = 1;
while (num > 0)
{
binaryNum = binaryNum + num % 2 * count;
count = count*10;
num = num / 2;
}
return binaryNum;
}


