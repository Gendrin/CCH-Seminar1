using Seminar1;
Console.WriteLine("Введите число по задаче №6, проверка на четность.");
string? snumber1 = Console.ReadLine();
if (snumber1 == null) Console.WriteLine("Введено значение null!");
else
{
    seminar1 sem1 = new seminar1(Int32.Parse(snumber1));
}
Console.WriteLine("Задача №2, проверка на максимум - два числа.");
Console.WriteLine("Введите число №1  к задаче №2, проверка на максимум.");
string? x1 = Console.ReadLine();
Console.WriteLine("Введите число №2  к задаче №2, проверка на максимум.");
string? y1 = Console.ReadLine();
if ((x1 == null)||(y1 == null)) Console.WriteLine("Введено значение null!");
else
{
    seminar1 sem1 = new seminar1(Int32.Parse(x1),Int32.Parse(y1));
}
Console.WriteLine("Задача №4, проверка на максимум - три числа.");
Console.WriteLine("Введите число №1  к задаче №4, проверка на максимум.");
x1 = Console.ReadLine();
Console.WriteLine("Введите число №2  к задаче №4, проверка на максимум.");
y1 = Console.ReadLine();
Console.WriteLine("Введите число №3  к задаче №4, проверка на максимум.");
string? z1 = Console.ReadLine();
if ((x1 == null)||(y1 == null)||(z1 == null)) Console.WriteLine("Введено значение null!");
else
{
    seminar1 sem1 = new seminar1(Int32.Parse(x1),Int32.Parse(y1),Int32.Parse(z1));
}