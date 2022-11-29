// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введи трёхзначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int a1 = Number / 10;
Console.WriteLine(a1);
int a3 = a1 % 10;
Console.WriteLine(a3);