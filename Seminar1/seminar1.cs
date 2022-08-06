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

    public void dz2 (int x, int y) 
    {
        if (x>y) Console.WriteLine($"Максимальное число из двух чисел: {x}");
            if(y>x) Console.WriteLine($"Максимальное число из двух чисел: {y}");
                else Console.WriteLine($"введенные два числа 1: {x}, 2: {y} равны.");
    }
    public void dz4 (int x, int y, int z) 
    {
        int max=x;
        if (x>y) max=x;
            if (y>max) max=y;
                if(z>max) max=z;
                    if ((max==x)&&(max==y)&&(max==z)) Console.WriteLine("Все три числа равны!");
                        else Console.WriteLine($"Максимальное число из трех чисел: {max}");
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