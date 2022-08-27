using DZ7;

dz dz7 = new dz();
//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
string[] inputString;
bool resultinLongArrRows;
bool resultinLongArrColumns;
Console.WriteLine("Please enter quantity rows & columnw array through whitespase!");
inputString = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
resultinLongArrRows = int.TryParse(inputString[0], out int longArrayRows);
resultinLongArrColumns = int.TryParse(inputString[1], out int longArrayColumns);
if(resultinLongArrRows&&resultinLongArrColumns)
{
    if(longArrayRows>0&&longArrayColumns>0)
    {
        Console.WriteLine($"m={longArrayRows},n={longArrayColumns}.");
        double[,] arrayDoubleNumbers = new double[longArrayRows, longArrayColumns];
        arrayDoubleNumbers=dz7.GetRandomArrayDouble(longArrayRows, longArrayColumns, dz.quantSigns.oneDigit, true);
        dz7.PrintArray<double>(arrayDoubleNumbers);
    }
    else Console.WriteLine("No correct Input number!Operation breaked!");
}
else Console.WriteLine("No correct Input number! Operation breaked!");
Console.WriteLine();

//Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//формируем массив случайных чисел 
Console.WriteLine("Please enter quantity rows & columnw array through whitespase for task50!");
inputString = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
resultinLongArrRows = int.TryParse(inputString[0], out int longArrayRowsTask50);
resultinLongArrColumns = int.TryParse(inputString[1], out int longArrayColumnsTask50);
//double[,] arrayDoubleTask50;
if (resultinLongArrRows && resultinLongArrColumns)
{
    if (longArrayRowsTask50 > 0 && longArrayColumnsTask50 > 0)
    {
        Console.WriteLine("Random array.");
        double[,] arrayDoubleTask50 = new double[longArrayRowsTask50, longArrayColumnsTask50];
        arrayDoubleTask50 = dz7.GetRandomArrayDouble(longArrayRowsTask50, longArrayColumnsTask50, dz.quantSigns.oneDigit, true);
        dz7.PrintArray<double>(arrayDoubleTask50);

        Console.WriteLine("Please choose element up prints arrays! Insert number row and column.");
        bool resultinElementArrRow;
        bool resultinElementArrColumn;
        inputString = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        resultinElementArrRow = int.TryParse(inputString[0], out int findElementRow);
        resultinElementArrColumn = int.TryParse(inputString[1], out int findElementColumn);
        Console.WriteLine($"Find element in array row={findElementRow}, column={findElementColumn}.");

        if (resultinElementArrRow && resultinElementArrColumn)
        {
            if (findElementRow >= 0 && findElementColumn >= 0)
            {
                Console.Write($"{findElementRow}, {findElementColumn} -> ");
                if (dz7.FindElementArray(findElementRow, findElementColumn, arrayDoubleTask50) != null)
                {
                    Console.Write($"{dz7.FindElementArray(findElementRow, findElementColumn, arrayDoubleTask50)}");
                }
                else Console.Write($"такого элемента в массиве нет");

            }
            else Console.WriteLine("No correct Input number!Operation breaked!");
        }
        else Console.WriteLine("No correct Input number! Operation breaked!");

    }
    else Console.WriteLine("No correct Input number!Operation breaked!");
}
else Console.WriteLine("No correct Input number! Operation breaked!");

Console.WriteLine();
//Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Please enter quantity rows & columnw array through whitespase for task 52!");
inputString = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
resultinLongArrRows = int.TryParse(inputString[0], out int longArrayRowsTask52);
resultinLongArrColumns = int.TryParse(inputString[1], out int longArrayColumnsTask52);
if (resultinLongArrRows && resultinLongArrColumns)
{
    if (longArrayRowsTask52 > 0 && longArrayColumnsTask52 > 0)
    {
        Console.WriteLine("Random array.");
        int[,] arrayIntegerTask52 = new int[longArrayRowsTask52, longArrayColumnsTask52];
        arrayIntegerTask52 = dz7.GetRandomArrayInteger(longArrayRowsTask52, longArrayColumnsTask52, dz.quantSigns.oneDigit, true);
        dz7.PrintArray<int>(arrayIntegerTask52);
        Console.Write("Среднее арифметическое каждого столбца: ");
        dz7.PrintArray<double>(dz7.ArithmeticAverageColumns(arrayIntegerTask52));
    }
    else Console.WriteLine("No correct Input number!Operation breaked!");
}
else Console.WriteLine("No correct Input number! Operation breaked!");
Console.WriteLine();