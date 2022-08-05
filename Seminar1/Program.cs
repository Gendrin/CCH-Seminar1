using Seminar1;
Console.WriteLine("Введите число по задаче №6, проверка на четность.");
string? snumber1 = Console.ReadLine();
if (snumber1 == null) Console.WriteLine("Введено значение null!");
else
{
    seminar1 sem1 = new seminar1(Int32.Parse(snumber1));
}


