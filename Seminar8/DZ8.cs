namespace DZ8
{
    public class dz
    {
        public enum quantSigns
        {
            oneDigit = 1,
            twoDigit,
            threeDigit,
            fourDigit,
            fiveDigit
        }

        public enum checkSplit
        {
            matrix,
            cube
        }

        public int[]? CheckInputSplitString(string[] splitWhitespaceString, checkSplit typeCheck)
        {
            int[]? resultArray = new int[splitWhitespaceString.Length];
            if ((typeCheck == checkSplit.matrix) && (resultArray.Length == 2))
            {
                if (int.TryParse(splitWhitespaceString[0], out int longArrayFierst) &&
                    int.TryParse(splitWhitespaceString[1], out int longArraySecond))
                {
                    if (longArrayFierst > 0 && longArraySecond > 0)
                    {
                        resultArray[0] = longArrayFierst;
                        resultArray[1] = longArraySecond;
                    }
                    else resultArray = null; return resultArray;
                }
                else resultArray = null; return resultArray;
            }
            
            if ((typeCheck == checkSplit.cube) && (resultArray.Length == 3))
            {
                if (int.TryParse(splitWhitespaceString[0], out int longArrayFierst) &&
                    int.TryParse(splitWhitespaceString[1], out int longArraySecond) &&
                    int.TryParse(splitWhitespaceString[2], out int longArrayThird))
                {
                    if (longArrayFierst > 0 && longArraySecond > 0 && longArrayThird > 0)
                    {
                        resultArray[0] = longArrayFierst;
                        resultArray[1] = longArraySecond;
                        resultArray[2] = longArrayThird;
                    }
                    else resultArray = null; return resultArray;
                }
                else resultArray = null; return resultArray;
            }
            else resultArray = null; return resultArray;
        }

        public int[,] GetRandomArrayInteger(int longArrayRows, int longArrColumns, quantSigns quantArraySigns, bool plusAndMinus)
        {
            int[,] resultArray = new int[longArrayRows, longArrColumns];
            Random randomInteger = new Random();
            int randomStart = 1 * (int)(Math.Pow(10, (int)quantArraySigns - 1));
            int randomEnd = (1 * (int)Math.Pow(10, (int)quantArraySigns));
            if (plusAndMinus) randomStart = 0 - randomEnd;
            for (int i = 0; i < resultArray.GetLength(0); i++)
            {
                for (int j = 0; j < resultArray.GetLength(1); j++)
                {
                    resultArray[i, j] = randomInteger.Next(randomStart, randomEnd);
                }
            }
            return resultArray;
        }

        public int[,] GetRandomArrayInteger(int longArrayRows, int longArrColumns, int rendomStart, int rendomEnd)
        {
            int[,] resultArray = new int[longArrayRows, longArrColumns];
            Random randomInteger = new Random();
            for (int i = 0; i < resultArray.GetLength(0); i++)
            {
                for (int j = 0; j < resultArray.GetLength(1); j++)
                {
                    resultArray[i, j] = randomInteger.Next(rendomStart, rendomEnd);
                }

            }
            return resultArray;
        }

        public void PrintArray<T>(T[,] printArray,bool twoDigit)
        {
            for (int i = 0; i < printArray.GetLength(0); i++)
            {
                for (int j = 0; j < printArray.GetLength(1); j++)
                {
                    if (twoDigit) Console.Write($"{printArray[i, j],6:d2} ");
                        else  Console.Write($"{printArray[i, j],6} ");
                    
                }
                Console.WriteLine();
            }
        }

        public void PrintArray<T>(T[] printArray, bool twoDigit)
        {
            for (int i = 0; i < printArray.Length; i++)
            {
                if (twoDigit) Console.Write($"{printArray[i],2:d2} ");
                    else Console.Write($"{printArray[i],2} ");
            }
            Console.Write(".");
        }
        //Task 54
        public int[,] TaskSort(int[,] inForSortArray)
        {
            int temp;
            for (int i = 0; i < inForSortArray.GetLength(0); i++)
            {
                for (int j = 0; j < inForSortArray.GetLength(1) - 1; j++)
                {
                    for (int k = j + 1; k < inForSortArray.GetLength(1); k++)
                    {
                        if (inForSortArray[i, j] < inForSortArray[i, k])
                        {
                            temp = inForSortArray[i, k];
                            inForSortArray[i, k] = inForSortArray[i, j];
                            inForSortArray[i, j] = temp;
                        }

                    }

                }
            }
            return inForSortArray;
        }
        //Task 56
        public int GetMinMatrixSumElemetsofRows(int[,] chexMatrix)
        {
            int sumNumbersInRows = 0, indexMinSumRows = 0, tempSum;
            for (int i = 0; i < chexMatrix.GetLength(0); i++)
            {
                tempSum = 0;
                for (int j = 0; j < chexMatrix.GetLength(1); j++)
                {
                    tempSum += chexMatrix[i, j];
                }
                if (i == 0)
                {
                    indexMinSumRows = 0;
                    sumNumbersInRows = tempSum;
                }
                if (tempSum < sumNumbersInRows)
                {
                    indexMinSumRows = i;
                    sumNumbersInRows = tempSum;
                }
            }
            return indexMinSumRows;
        }

        // Task 58
        public void MultiplexingMatrix(int[,] matrix, int[,] matrix2)
        {
            if (matrix.GetLength(1) == matrix2.GetLength(0))
            {
                int[,] multRezultMatrix = new int[matrix.GetLength(0), matrix2.GetLength(1)];

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix2.GetLength(1); j++)
                    {
                        for (int k = 0; k < matrix2.GetLength(0); k++)
                        {
                            multRezultMatrix[i, j] += matrix[i, k] * matrix2[k, j];
                        }
                    }
                }
                Console.WriteLine("Result mult!");
                PrintArray<int>(printArray: multRezultMatrix,
                                        twoDigit: false);

            }
            else Console.WriteLine("Columns matrix1 != rows matrix2, multiplexing inpossible !");
        }

public int[,]? GetHandEnterMatrix()
        {
        string[] instring;
        int[,]? matrix;
        Console.WriteLine("Please enter razmer matrix N x M with probel!");

                instring = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (int.TryParse(instring[0], out int a) && int.TryParse(instring[1], out int b))
            {
                matrix = new int[a, b];

                Console.WriteLine($"Insert razmer matrix {a} x {b}!");
                for (int i = 0; i < a; i++)
                {
                    //string[] instring2;
                    Console.WriteLine($"Please enter {i + 1} rows matrix with probel!");
                    instring = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    for (int j = 0; j < instring.Length; j++)
                    {
                        if (int.TryParse(instring[j], out int c)) matrix[i, j] = c;
                    }
                }
                return matrix;

            }
            else matrix = null; return matrix;  
         }

        public int[,]? GetRendomMatrix()
        {
            string[] inputString;
            Console.WriteLine("Please enter quantity rows & columnw array through whitespase!");
            inputString = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[]? resultInsertStringArray;
            int[,]? arrayIntegerNumbers;

            resultInsertStringArray = CheckInputSplitString(inputString, checkSplit.matrix);

            if (resultInsertStringArray != null)
            {
                arrayIntegerNumbers = new int[resultInsertStringArray[0], resultInsertStringArray[1]];

                arrayIntegerNumbers = GetRandomArrayInteger(longArrayRows: resultInsertStringArray[0],
                                                                longArrColumns: resultInsertStringArray[1],
                                                                quantArraySigns: quantSigns.oneDigit,
                                                                plusAndMinus: false);
                return arrayIntegerNumbers;
            }
            else arrayIntegerNumbers = null; return arrayIntegerNumbers;
        }

        public void Task60()
        {
            string[] inputString;
            int[,,] x3Array;
            int[]? resultInsertStringArray;
            Console.WriteLine("Please enter range matrix for task N60");
            Console.WriteLine("Please enter razmer Array a x b x c with probel!");
            inputString = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            resultInsertStringArray = CheckInputSplitString(inputString, checkSplit.cube);
            if (resultInsertStringArray != null)
            {
                x3Array = new int[resultInsertStringArray[0], resultInsertStringArray[1], resultInsertStringArray[2]]; int startNumber = 9;
                if (resultInsertStringArray[0] * resultInsertStringArray[1] * resultInsertStringArray[2] < 90)
                {
                    for (int i = 0; i < x3Array.GetLength(2); i++)
                    {
                        for (int j = 0; j < x3Array.GetLength(0); j++)
                        {
                            for (int k = 0; k < x3Array.GetLength(1); k++)
                            {
                                x3Array[j, k, i] = startNumber + 1;
                                Console.Write($"{x3Array[j, k, i]}({j},{k},{i}) ");
                                startNumber++;
                            }
                            Console.WriteLine();
                        }
                    }

                }
                else Console.WriteLine("Range Array > 90");

            }
            else Console.WriteLine("No correct enters!");
        }

        public int [,] Task62(int inMatrix)
        {
            int[,] numarr = new int[inMatrix, inMatrix];

            int st_x = -1, st_y = -1, x, y;
            int temp = 0; // переменная меняющегося числа забиваемого в массив
            int tnumber; // переменная меняющейся размерности в зависимости от номера спирали
            tnumber = inMatrix;
            // Определим количество спиралей и наличие точки.
            int nsp = tnumber / 2; //количество спиралей
            bool point = false;  //наличие точки
            if (tnumber % 2 != 0) point = true;
            Console.WriteLine(value: $"Выводим до: {inMatrix * inMatrix}, количество спиралей {nsp} точка = {point}");
            // Заполняем спирали
            for (int sp = 1; sp <= nsp; sp++)
            {
                st_x++; st_y++; //стартовое положение в массиве при начале ввода данных спирали
                x = st_x; y = st_y;

                tnumber = inMatrix - (sp - 1);

                // Первая грань
                for (; x < tnumber; x++)
                {
                    temp++;
                    numarr[y, x] = temp;
                }
                x--; y++;
                //Вторая грань
                for (; y < tnumber; ++y)
                {
                    temp++;
                    numarr[y, x] = temp;
                }
                //Третья грань
                y--; x--;
                for (; x >= st_x; x--)
                {
                    temp++;
                    numarr[y, x] = temp;
                }
                //Четвертая грань
                x++; y--;
                for (; y > st_y; --y)
                {
                    temp++;
                    numarr[y, x] = temp;
                }
            }
            //Устанавливаем точку
            if (point) numarr[++st_y, ++st_x] = temp + 1;
            return numarr;
            
        }
    }
}