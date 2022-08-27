using DZ6;
dz dz6 = new dz();

//Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
//Не удается сделать перенос строки в {}
Console.WriteLine("Please enter numbers through whitespase!");
Console.Write($" -> {dz6.FindNumberMoreZero(Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries))}");
Console.WriteLine();

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)
//Не удается сделать перенос строки в {}
Console.WriteLine("Please enter numbers through whitespase!");
Console.WriteLine("b1 k1 b2 k2");
Console.Write($"{dz6.FindIntersectionPointLine(Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries))}");