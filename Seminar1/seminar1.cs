namespace Seminar1
{
    public class seminar1
    {
         private int number1;
      private bool numchet;
      public int Number
        {
            get {return number1;}
            set {number1 = value;}
        }  
        public bool Numchet
        {
            get {return numchet;}
        }
    public seminar1 (int n)
    {
        number1=n; if (n%2==0) 
                        {numchet=true;Console.WriteLine($"Введенное число: {n} четное");}
                        else
                            {numchet=false;Console.WriteLine($"Введенное число: {n} нечетное");}
    }
    }
}