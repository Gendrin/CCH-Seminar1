namespace DZ2
{
    public class dzSeminar2
    {
        public int zadacha10(int n)
        {
            return (n / 10) % 10;
        }

        public int? zadacha13(int num, int koldigitnum)
        {
            int[] narr = new int[koldigitnum];
            if (koldigitnum > 2)
            {
                //Заполняем массив
                for (int i = 0; i < koldigitnum; i++)
                {
                    narr[i] = num % 10;
                    num /= 10;
                }
                //Разворачиваем массив
                for (int i = 0; i < koldigitnum / 2; i++)
                {
                    num = narr[i];
                    narr[i] = narr[((koldigitnum - 1) - i)];
                    narr[(koldigitnum - 1) - i] = num;
                }
                return narr[2];
            }
            else return null;
        }

        public string zadacha15(int num)
        {
            if (num > 0 && num < 8)
            {
                if (num > 0 && num < 6) return "нет - день рабочий!";
                    else return "да - день выходной!";
            }
            else return "введено неверное значение дня недели";
        }
    }
    
}