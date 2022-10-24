Console.Clear();

// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да



// Вариант 1

// Console.WriteLine("Введите пятизначное число");

// int number = Convert.ToInt32(Console.ReadLine());
// int numberB = number;
// int num = 0;
// int count = 100000;
// if (number < 99999 && number > 9999)
// {
//     while (count >= 10)
//     {
//         num = num + (numberB % 10) * (count / 10);
//         numberB = numberB / 10;
//         count = count / 10;

//     }
//     if (number == num)
//     {
//         Console.WriteLine($"Число {number}  палиндром");
//     }
//     else
//     {
//         Console.WriteLine($"Число {number}  не является палиндромом");
//     }
// }
// else
// {
//     Console.WriteLine($"Неверный ввод");
// }






// Вариант 2


// int numberB(int numB)
// {
//     int num = 0;
//     int count = 100000;

//     while (count >= 10)
//     {
//         num = num + (numB % 10) * (count / 10);
//         numB = numB / 10;

//         count = count / 10;
//     }
//     return num;
// }

// Console.WriteLine("Введите пятизначное число");

// int number = Convert.ToInt32(Console.ReadLine());

// if (number < 99999 && number > 9999)
// {
//     if (number == numberB(number))
//     {
//         Console.WriteLine($"Число {number}  палиндром");
//     }
//     else
//     {
//         Console.WriteLine($"Число {number}  не является палиндромом");
//     }
// }
// else
// {
//     Console.WriteLine($"Неверный ввод");
// }


// вариант 3 после лекции

Console.WriteLine("Введите пятизначное число");

string number = Console.ReadLine();
string numberB = String.Empty;
int lengh = number.Length - 1;
while (lengh > 0)
{
    numberB = numberB + number[lengh];
    lengh--;
}
numberB = numberB + number[0];

if (number == numberB)
{
    Console.WriteLine($"Число {number}  палиндром");
}
else
{
    Console.WriteLine($"Число {number}  не является палиндромом, наоборот вот так {number}");
}



