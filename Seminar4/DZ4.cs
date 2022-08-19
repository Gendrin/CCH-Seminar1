namespace DZ4
{
    public class dz
    {
        //Задача 25 
        public int degryAinB(int a,int b)
        {
            int result = 1;
            for (int i = 1; i <= b; i++)
                {
                 result *= a;
                }
            return result;
        }

        //Задача 27
        public int numerology(int innumber)
        {

            if (innumber < 0) innumber = Math.Abs(innumber);
            int result = 0; 
            for (; innumber > 0;)
            {
                if (innumber % 10 > 0)
                {
                 result += (innumber % 10);
                 innumber /= 10;
                 }
                else
                {
                    result += innumber;
                    innumber /= innumber;
                }
            }
            return result;
        }

        //Задача 29 два метода
        public int[] GetRandomArray(int longArray)
        {
            int[] warr = new int[longArray];
            Random rnd = new Random();
            for (int i = 0; i < warr.Length; i++)
            {
                warr[i] = rnd.Next(1, 100);
            }
            return warr;
        }
        public void PrintArray(int[] parray)
        {
            Console.Write("[");
            for (int i = 0; i < parray.Length; i++)
            {
                if (i == parray.Length - 1) Console.Write($"{parray[i]}");
                else Console.Write($"{parray[i]} ");
            }
            Console.Write("]");
        }
    }
}