namespace DZ3
{
    public class dzseminar3
    {
        public struct Point
    {
        public double X;
        public double Y;
        public double Z;
    }
            
        internal class dzSeminar3

    {
        //Задача 19
        //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

        public bool zadacha19(int n)
        {
            if (((n / 10000) == (n % 10)) && ((n / 1000) % 10) == ((n / 10) % 10)) return true;
                else return false;
        }

        //Задача 21
        //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
        public double zadacha21(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow((a.X - b.X), 2) + Math.Pow((a.Y - b.Y), 2) + Math.Pow((a.Z - b.Z), 2));
        }

        //Задача 23
        //Напишите программу, которая принимает на вход число(N) и выдаёт таблицу кубов чисел от 1 до N.
        public string zadacha23(int n)
        {
            long[] marr = new long[n];
            string result = "";
            for (int i = 0; i < n; i++)
            {
                marr[i] = (long)Math.Pow(i+1, 3);
                result+=marr[i].ToString()+" ";
            }
            return result;
        }

    }
    }
}