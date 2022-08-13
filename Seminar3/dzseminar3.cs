namespace DZ3
{
    public struct Point
    {
        public double X;
        public double Y;
        public double Z;
    }
            
        public class dzseminar3

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
            string result = "";
                for (int i = 1; i < n; i++)  result+=((long)Math.Pow(i, 3)).ToString()+" ";
                    return result;
        }

    }
    
}