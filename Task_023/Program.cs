﻿Console.Clear();






// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите целое число");

int number = Convert.ToInt32(Console.ReadLine());

for (double i = 1; i < number; i++)
{
    Console.WriteLine($"{i} в кубе будет {Math.Pow(i, 3)},");
}
Console.WriteLine($"{number} в кубе будет {Math.Pow(number, 3)}.");