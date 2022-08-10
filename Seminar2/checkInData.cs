namespace CID
{
    public class checkInData
    {
         public struct structInData
    {
        public double inNumber;
        public bool correct;
        public bool result;
    }

   public structInData CheckInData(string? snum)
    {
        structInData result;
        if (string.IsNullOrWhiteSpace(snum))
        {
            Console.WriteLine("Введено пустое значение или null");
            result.result = false; // Результат ввода
            result.correct = false; // Результат корректировки
            result.inNumber = 0; // Выводимое число
            return result;
        }
        else
        {
            char[] testA = snum.ToCharArray();
            char[] innumbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ',' };
            bool check = false; result.correct = false;
            for (int i = 0; i < testA.Length; i++)
            {
                foreach (char fchar in innumbers)
                {
                    if (fchar == testA[i])
                    {
                        check = true;
                        break;
                    }
                    else if (testA[i] == '.')
                    {
                        testA[i] = ',';
                        result.correct = true;
                    }

                    else
                    {
                        check = false;
                    }
                }
                if (!check)
                {
                    Console.WriteLine($"Введен неверный символ {i + 1}:{snum[i]} не является цифрой или ','");
                    break;
                }
            }

            string rezstring = new string(testA);
            if (check)
            {
                result.result = true;
                result.inNumber = double.Parse(rezstring);
            }
            else
            {
                result.result = false;
                result.inNumber = 0;
            }
            return result;
        }
    }

    public int checkKolNumber(int num)
    {
        int result = 0;
       do
         {
          num/= 10;
          result++;
          }
        while (num!= 0) ;
        return result;
    }

    }

}