namespace CID
{
    //Класс для проверки входящих данных
    //для использования необходимо добавить файл в дирректорию проекта
    //и в файле program - основной программы добавить пространство имен 
    //командой using CID; в самом вверху. Далее объявляем переменную класса
    //и уже работаем дальше с ней, 
    // как объявляем - checkInData checkdata-это имя может быть любое = new checkInData();, 
    //- где checkdata переменная.
    //данный класс имеет одну структуру/тип и два метода.
    //зачем понадобилась структура? - нужно было вернуть не одно значение а несколько
    //т.е. структура structInData имеет три поля inNumber - возврящаемое число типа double
    //correct- производилась ли корректировка false/true, и результат проверки result- если false то ввод
    // данных неудачен.
    //
    public class checkInData
    {
         public struct structInData
    {
        public double inNumber;
        public bool correct;
        public bool result;
    }
//Метод класса CheckInData - входное значение строка с возможным null значением.
//Выходное значение - структура данных где три значения.
   public structInData CheckInData(string? snum)
    {
        structInData result;
        //Первая проверка на ввод пустого значения или null
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
            //Вторая проверка каждого введеного символа на принадлежность массиву innumber
            //где есть только цифры и запятая
            char[] testA = snum.ToCharArray(); //Строка преобразуется в массив символов char
            char[] innumbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
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
                    else if ((testA[i] == ',') && (i != 0))
                    {
                        check = true;
                        break;
                    }
                    else if ((testA[i] == '.') && (i != 0))
                    {
                            testA[i] = ',';
                            result.correct = true;
                            check = true;
                            break;
                     }
                    else if ((testA[i] == '-') && (i == 0))
                    {
                        check = true;
                        break;
                    }

                    else
                    {
                        check = false;
                    }
                }
                //Если символ не входит в массив разрешенных символов отображаем его и проверка завершается
                if (!check)
                {
                    Console.WriteLine($"Введен неверный символ {i + 1}:{snum[i]} не является цифрой или ','");
                    break;
                }
            }
//После проверки массив символов testA преобразуется обратно в строку и если проверка удачна
//результат - true
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
//Второй метод для подсчета количества цифр в челом числе. Принимет int число
//возвращает int количество цифр.
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