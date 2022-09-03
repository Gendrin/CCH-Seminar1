using DZ9;

dz dz9 = new dz();

//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//Выполнить с помощью рекурсии.
Console.WriteLine("Please enter N numbers for task N64");
if (int.TryParse(Console.ReadLine(), out int N))
{
    Console.Write($"N={N} -> \"");
    dz9.PrintNum(N);
    Console.WriteLine();
}
else Console.WriteLine("No correct enters!");

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
string[] inputString;
Console.WriteLine("Please enter N & M numbers for taskN 66 through whitespase!");
inputString = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

int[]? resultInsertStringArray;

resultInsertStringArray = dz9.CheckInputSplitString(inputString, dz.checkSplit.matrix);

if (resultInsertStringArray != null)
{
    Console.Write($"M = {resultInsertStringArray[0]};N = {resultInsertStringArray[1]} ->" +
                  $" {dz9.SumNum(resultInsertStringArray[0], resultInsertStringArray[1])}");
}
else Console.WriteLine("No correct enters!");
Console.WriteLine();

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
uint result;
Console.WriteLine("Please enter N & M numbers for taskN 68 (function Akkermana) through whitespase!");
inputString = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

resultInsertStringArray = dz9.CheckInputSplitString(inputString, dz.checkSplit.matrix);

if (resultInsertStringArray != null)
{
    result = dz9.Akkerman((uint)resultInsertStringArray[0], (uint)resultInsertStringArray[1]);
    Console.WriteLine($"m={resultInsertStringArray[0]},n={resultInsertStringArray[1]} -> A(m,n) = {result}");
    
}
else Console.WriteLine("No correct enters!");

