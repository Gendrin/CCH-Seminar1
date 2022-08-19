namespace DZ5
{
    public class dz
    {
        //Задача 34
        //Получение массива целых чисел, где quantSigns - разрядность (1 - от 0-9, 2 - от 10 - 99, 3 - от 100 - 999 и т.д.
        //plusAndminus - включение в диапазон отрицательных чисел
        public int[]GetRandomArray (int longArray, int quantSigns, bool plusAndminus)
        {
            int[] warr = new int[longArray];
            Random rnd = new Random();
            int rndStart = 1 * (int)(Math.Pow(10, quantSigns - 1));
            int rndEnd = (1 * (int)Math.Pow(10, quantSigns));
            if (plusAndminus) rndStart = 0 - rndEnd;
            for (int i = 0; i < warr.Length; i++)

            {
                warr[i] = rnd.Next(rndStart, rndEnd);
            }
            return warr;
        }

        //Получение массива вещественных чисел, где quantSigns - разрядность (1.0 - от 0.0-9.0, 2.0 - от 10.0 - 99.0, 3.0 - от 100.0 - 999.0 и т.д.
        //криво перегруженный метод, перегрузка имхо притянута за уши
        public double[] GetRandomArray(int longArray, double quantSigns, bool plusAndminus)
        {
            double[] warr = new double[longArray];
            Random rndD = new Random(); //Рендом для вещественного числа
            Random rndI = new Random(); //Рендом знака для вещественного числа
            double rndEnd = (1 * Math.Pow(10, quantSigns) - 1);
            int rndStartI = -1;
            int rndEndI = 2;
            int znak = 1;
            for (int i = 0; i < warr.Length; i++)

            {
                   if (plusAndminus)
                        {
                        do
                        {
                            znak = rndI.Next(rndStartI, rndEndI);
                        }
                        while (znak == 0);
                        }
                warr[i] = Math.Round((rndD.NextDouble() * rndEnd*znak),2);

            }
            return warr;
        }
        // Обобщенный метод вывода массива, под int & double
        public void PrintArray <T>(T[] parray)
        {
            Console.Write("[");
            for (int i = 0; i < parray.Length; i++)
            {
                if (i == parray.Length - 1) Console.Write($"{parray[i]}");
                else Console.Write($"{parray[i]} ");
            }
            Console.Write("]");
        }

        //Задача 34 вывод четных чисел из массива
        public int quantityEvenNumbers(int[] checkarray)
        {
            int result = 0;
            for (int i = 0; i < checkarray.Length; i++)
            {
                if (checkarray[i] % 2 == 0) result++;
            }
            return result;
        }

        //Задача 36 - сумма элементов массива на нечетных индексах
        public int SumOddElementArray(int[] checkarray)
        {
            int result = 0;
            for (int i = 1; i < checkarray.Length; i+=2)
            {
                result += checkarray[i];
            }
            return result;
        }
        //Задача 38 - разница между максимальным и минимальным элементом массива
        public double MinAndMax(double[] checkarray)
        {
            double maxN = checkarray[0];
            double minN = checkarray[0];
            for (int i = 1; i < checkarray.Length; i++)
            {
                if (maxN<checkarray[i]) maxN = checkarray[i];
                if (minN>checkarray[i]) minN = checkarray[i];
            }
            return maxN-minN;

        }


    }
}