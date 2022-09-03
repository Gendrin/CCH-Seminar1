using DZ8;

int[,]? matrix;
int[,]? matrix2;
dz dz8 = new dz();


//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.WriteLine("Please enter metod entering matrix handle -> 1 or rendom -> 0 ? For task N54");
if (int.TryParse(Console.ReadLine(), out int selectEnterTask54))
    {
        if (selectEnterTask54 == 0) matrix = dz8.GetRendomMatrix();
            else if (selectEnterTask54 == 1) matrix = dz8.GetHandEnterMatrix();
                else
                    {
                         Console.WriteLine("Not enter metod entering matrix, auto ->rendom");
                         matrix = dz8.GetRendomMatrix();
                    }
    
    if (matrix != null)
        {
        Console.WriteLine("Insert matrix!");
            dz8.PrintArray<int>(printArray: matrix,
                                twoDigit: false);
        //Выполнение сортировки массива (решение задачи N54)
        matrix = dz8.TaskSort(matrix);
        Console.WriteLine();
        Console.WriteLine("Result sort!");
        dz8.PrintArray<int>(printArray: matrix,
                                twoDigit: false);
    }
    }
    else Console.WriteLine("No correct enters!");

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("Please enter metod entering matrix handle -> 1 or rendom -> 0 ? For task N56");
if (int.TryParse(Console.ReadLine(), out int selectEnterTask56))
{
    if (selectEnterTask56 == 0) matrix = dz8.GetRendomMatrix();
        else if (selectEnterTask56 == 1) matrix = dz8.GetHandEnterMatrix();
            else
            {
                Console.WriteLine("Not enter metod entering matrix, auto ->rendom");
                matrix = dz8.GetRendomMatrix();
            }

    if (matrix != null)
    {
        Console.WriteLine("Insert matrix!");
        dz8.PrintArray<int>(printArray: matrix,
                            twoDigit: false);

        Console.WriteLine($"{dz8.GetMinMatrixSumElemetsofRows(matrix) + 1} строка");
    }
}
else Console.WriteLine("No correct enters!");

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.WriteLine("Please enter metod entering matrixs handle -> 1 or rendom -> 0 ? For task N58");
if (int.TryParse(Console.ReadLine(), out int selectEnterTask58))
{
    if (selectEnterTask58 == 0)
    {
        Console.WriteLine("Insert matrix N1 For task N58");
        matrix = dz8.GetRendomMatrix();
        Console.WriteLine("Insert matrix N2 For task N58");
        matrix2 = dz8.GetRendomMatrix();
    }
    else if (selectEnterTask58 == 1)
    {
        Console.WriteLine("Insert matrix N1 For task N58");
        matrix = dz8.GetHandEnterMatrix();
        Console.WriteLine("Insert matrix N2 For task N58");
        matrix2 = dz8.GetHandEnterMatrix();
    }
    else
    {
        Console.WriteLine("Not enter metod entering matrix, auto ->rendom");
        Console.WriteLine("Insert matrix N1 For task N58");
        matrix = dz8.GetRendomMatrix();
        Console.WriteLine("Insert matrix N2 For task N58");
        matrix2 = dz8.GetRendomMatrix();
    }

    if ((matrix != null)&& (matrix2 != null))
    {
        Console.WriteLine("Insert matrix number 1!");
        dz8.PrintArray<int>(printArray: matrix,
                            twoDigit: false);
        Console.WriteLine("Insert matrix number 2!");
        dz8.PrintArray<int>(printArray: matrix2,
                            twoDigit: false);
        //Умножение матриц
        dz8.MultiplexingMatrix(matrix, matrix2);
     }
}
else Console.WriteLine("No correct enters!");

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.axbxc<90
dz8.Task60();


//Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
Console.WriteLine("Please enter range matrix for task N62");
if (int.TryParse(Console.ReadLine(), out int rangeMatrix))
        dz8.PrintArray<int>(printArray: dz8.Task62(rangeMatrix), twoDigit: true);
    else Console.WriteLine("No correct enters!");