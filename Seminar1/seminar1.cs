namespace Seminar1
{
    public class seminar1
    {
      private int number1;
      private bool numchet;
      public int Number
        {
            get {return number1;}
            set {number1 = value;
                if (number1%2==0) numchet=true;
                    else numchet=false;
                }
        }  
        public bool Numchet
        {
            get {return numchet;}
        }
    public seminar1 (int n) // Конструктор с определением четности
    {
        number1=n; if (n%2==0) 
                        {numchet=true;Console.WriteLine($"Введенное число: {n} четное");}
                        else
                            {numchet=false;Console.WriteLine($"Введенное число: {n} нечетное");}
    }
    public seminar1 (int x, int y) // Конструктор с определением максимального числа из двух чисел
    {
        if (x>y) Console.WriteLine($"Максимальное число из двух чисел: {x}");
            else Console.WriteLine($"Максимальное число из двух чисел: {y}");
    }
    public seminar1 (int x, int y, int z) // Конструктор с определением максимального числа из трех чисел
    {
        int max=x;
        if (x>y) max=x;
            if (y>max) max=y;
                if(z>max) max=z;
            Console.WriteLine($"Максимальное число из трех чисел: {max}");
    }
    public void zd8 (int num8)
    {
        Console.WriteLine($"Отображаем все четные числа от 1 до {num8} ");
        for (int i=1; i<=num8; ++i)
            {
              if (i%2==0) Console.Write($" {i}");
            }
    }
    }

}