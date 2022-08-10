using Seminar1;
Console.WriteLine("Введите число по задаче №6, проверка на четность.");
string? snumber1 = Console.ReadLine();
//if (string.IsNullOrWhiteSpace(snumber1))

if (string.IsNullOrWhiteSpace(snumber1)) Console.WriteLine("Значение не введено!");
   else 
   {
    seminar1 sem1 = new seminar1();
    sem1.Number=Int32.Parse(snumber1);
    if (sem1.Numchet) Console.WriteLine($"Введенное число: {sem1.Number} четное");
        else Console.WriteLine($"Введенное число: {sem1.Number} нечетное");
    //Задача №2
    Console.WriteLine("Задача №2, проверка на максимум - два числа.");
    Console.WriteLine("Введите число №1  к задаче №2, проверка на максимум.");
    string? x1 = Console.ReadLine();
    Console.WriteLine("Введите число №2  к задаче №2, проверка на максимум.");
    string? y1 = Console.ReadLine();
    if ((string.IsNullOrWhiteSpace(x1))||(string.IsNullOrWhiteSpace(y1))) Console.WriteLine("Значение не введено!");
        else
            {
            sem1.dz2(Int32.Parse(x1),Int32.Parse(y1));
            }
    //Задача №4
    Console.WriteLine("Задача №4, проверка на максимум - три числа.");
    Console.WriteLine("Введите число №1  к задаче №4, проверка на максимум.");
    x1 = Console.ReadLine();
    Console.WriteLine("Введите число №2  к задаче №4, проверка на максимум.");
    y1 = Console.ReadLine();
    Console.WriteLine("Введите число №3  к задаче №4, проверка на максимум.");
    string? z1 = Console.ReadLine();
    if ((string.IsNullOrWhiteSpace(x1))||(string.IsNullOrWhiteSpace(y1))||
            (string.IsNullOrWhiteSpace(z1))) Console.WriteLine("Значение не введено!");
        else sem1.dz4(Int32.Parse(x1),Int32.Parse(y1),Int32.Parse(z1));
        
    //Задача №8
    Console.WriteLine("Задача №8, отображаем четные числа от 1 до N.");    
    x1 = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(x1)) Console.WriteLine("Значение не введено!");
            else
                {
                sem1.zd8(Int32.Parse(x1));
                }
   }


