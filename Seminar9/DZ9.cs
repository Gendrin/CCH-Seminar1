namespace DZ9
{
    public class dz
    {
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
             
        //Task 64
        public void PrintNum(int n)
        {
            if (n == 1) Console.Write($"{n}\"");
            else
            {
                Console.Write($"{n},");
                n--;
                PrintNum(n);
            }
        }
        //Task 66
        public int SumNum(int m, int n)
        {
            if (m > n) return 0;
            else
            {
                return m + SumNum(m + 1, n);
            }
        }

        //Task68
        public uint Akkerman(uint n, uint m)
        {
            if (n == 0)
                return m + 1;
            else
                if ((n != 0) && (m == 0))
                return Akkerman(n - 1, 1);
            else
                return Akkerman(n - 1, Akkerman(n, m - 1));
        }
    }
}