namespace DZ7
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
                    resultArray[i,j] = randomInteger.Next(randomStart, randomEnd);
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

        public double[,] GetRandomArrayDouble(int longArrayRows, int longArrayColumns, int randomMaxNumber, bool plusAndMinus)
        {
            double[,] resultArray = new double[longArrayRows, longArrayColumns];
            Random randomDouble = new Random(); //Рендом для вещественного числа
            Random randomZero = new Random(); //Рендом знака для вещественного числа
            int randomStartZero = -1;
            int randomFinZezo = 2;
            int znak = 1;
            for (int i = 0; i < resultArray.GetLength(0); i++)

            {
                for (int j = 0; j < resultArray.GetLength(1); j++)
                {
                    if (plusAndMinus)
                    {
                        do
                        {
                            znak = randomZero.Next(randomStartZero, randomFinZezo);
                        }
                        while (znak == 0);
                    }
                    resultArray[i, j] = Math.Round(randomDouble.NextDouble() * randomMaxNumber * znak, 2);
                }

            }
            return resultArray;
        }

        public double[,] GetRandomArrayDouble(int longArrayRows,int longArrayColumns, quantSigns quantArraySigns, bool plusAndminus)
        {
            double[,] resultArray = new double[longArrayRows, longArrayColumns];
            Random randomDouble = new Random(); //Рендом для вещественного числа
            Random randomZero = new Random(); //Рендом знака для вещественного числа
            double randomEnd = 1 * Math.Pow(10, (int)quantArraySigns) - 1;
            int randomStartZero = -1;
            int randomFinishZezo = 2;
            int znak = 1;
            for (int i = 0; i < resultArray.GetLength(0); i++)

            {
                for (int j = 0; j < resultArray.GetLength(1); j++)
                {
                    if (plusAndminus)
                    {
                        do
                        {
                            znak = randomZero.Next(randomStartZero, randomFinishZezo);
                        }
                        while (znak == 0);
                    }
                    resultArray[i,j] = Math.Round(randomDouble.NextDouble() * randomEnd * znak, 2);
                }
            }
            return resultArray;
        }

        public void PrintArray<T>(T[,] parray)
        {
            for (int i = 0; i < parray.GetLength(0); i++)
            {
                for (int j = 0; j < parray.GetLength(1); j++)
                {
                    //Console.Write($"{parray[i, j],6} ");
                    if (parray[i, j] is Int32) Console.Write($"{parray[i, j],6:d2} ");
                        else Console.Write($"{parray[i, j],6} ");
                }
                Console.WriteLine();
            }
        }

        public void PrintArray<T>(T[] parray)
        {
            for (int i = 0; i < parray.Length; i++)
            {
                if (i == parray.Length - 1) Console.Write($"{parray[i]}");
                else Console.Write($"{parray[i]}; ");
            }
            Console.Write(".");
        }
        // Task50
        public double? FindElementArray (int rowElement, int columnElement, double[,] arrayForFind)
        {
            if (rowElement < arrayForFind.GetLength(0) && columnElement < arrayForFind.GetLength(1))
            {
                return arrayForFind[rowElement, columnElement];
            }
            else return null;
        }

        public double[] ArithmeticAverageColumns (int[,] arrayForArithmetic)
        {
            double[] result = new double[arrayForArithmetic.GetLength(1)];
            
            for (int j = 0; j < arrayForArithmetic.GetLength(1); j++)
            {
                double sumColumn = 0;
                for (int i = 0; i < arrayForArithmetic.GetLength(0); i++)
                {
                    sumColumn += arrayForArithmetic[i, j];
                }
                result[j] = Math.Round(sumColumn/arrayForArithmetic.GetLength(0),1);
            }
            return result;
        }
    }
}