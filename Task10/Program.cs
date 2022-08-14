// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine ("Введите трёхзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int result = (N / 100) * 100;
int result2 = (N - result) / 10;
Console.WriteLine($"Вторая цифра числа {N} - {result2}");