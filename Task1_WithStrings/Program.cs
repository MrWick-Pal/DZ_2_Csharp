// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введи трёхзначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(Number);

if (stringNumber.Length < 3 || stringNumber.Length > 3)
{
    Console.WriteLine("Число не является трёхзначным.");
}
else
{
    Console.WriteLine("вторая цифра этого числа: " + stringNumber[1]);
}