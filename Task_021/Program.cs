Console.Clear();


//Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


// Вариант 1

// Console.WriteLine("Введите координаты двух точек чтобы найти расстояние между ними");
// Console.WriteLine("первая точка, Введите координату X");
// int coordinateAx = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("первая точка, Введите координату Y");
// int coordinateAy = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("первая точка, Введите координату Z");
// int coordinateAz = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("вторая точка, Введите координату X");
// int coordinateBx = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("вторая точка, Введите координату Y");
// int coordinateBy = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("вторая точка, Введите координату Z");
// int coordinateBz = Convert.ToInt32(Console.ReadLine());

// double l = Math.Sqrt(Math.Pow((coordinateAx - coordinateBx), 2) + Math.Pow((coordinateAy - coordinateBy), 2) + Math.Pow((coordinateAz - coordinateBz), 2));

// Console.WriteLine(Math.Round(l, 2));


Console.WriteLine("Введите координаты двух точек чтобы найти расстояние между ними");
Console.WriteLine("Первая точка, Введите координату X Y Z");
int[] coordinateAxyz = { Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()) };

Console.WriteLine("Вторая точка, Введите координату X Y Z");
int[] coordinateBxyz = { Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()) };

double l = Math.Sqrt(Math.Pow((coordinateAxyz[0] - coordinateBxyz[0]), 2) + Math.Pow((coordinateAxyz[1] - coordinateBxyz[1]), 2) + Math.Pow((coordinateAxyz[2] - coordinateBxyz[2]), 2));

Console.WriteLine(Math.Round(l, 2));
