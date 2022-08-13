using CID;
using DZ3;

checkInData checkdata = new checkInData();
checkInData.structInData InData;

//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите целое пятизначное число!");

InData = checkdata.CheckInData(Console.ReadLine());

if (!InData.result) Console.WriteLine("Ввод данных неудачен необходимо повторить ввод данных!");
    else Console.WriteLine($"Введено значение {InData.inNumber}");
        if (InData.correct) Console.WriteLine("Произведена корректровка '.' на ','");

int kolnumber = checkdata.checkKolNumber((int)InData.inNumber);

dzseminar3 dz3 = new dzseminar3();


if (kolnumber != 5) Console.WriteLine($"Вы ввели не пятизначное число! -> : {InData.inNumber}");
else if (dz3.zadacha19((int)InData.inNumber)) Console.WriteLine("да");
    else Console.WriteLine("нет");

//Задача 21
Console.WriteLine("Введите координаты двух точек в 3д пространстве!");
//Производим инициализацию для предотвращения ощибки неверного ввода
Point PointA; PointA.X = 0; PointA.Y = 0; PointA.Z = 0;
Point PointB; PointB.X = 0; PointB.Y = 0; PointB.Z = 0;
bool ErrorIn=false; // Ошибка ввода.
Console.WriteLine("Точка А! Координата Х");
InData = checkdata.CheckInData(Console.ReadLine());
if (InData.result) PointA.X = InData.inNumber;
    else ErrorIn = true;

if (!ErrorIn)
{
    Console.WriteLine("Точка А! Координата Y");
    InData = checkdata.CheckInData(Console.ReadLine());
    if (InData.result) PointA.Y = InData.inNumber;
        else ErrorIn = true;
}

if (!ErrorIn)
{
    Console.WriteLine("Точка А! Координата Z");
    InData = checkdata.CheckInData(Console.ReadLine());
    if (InData.result) PointA.Z = InData.inNumber;
        else ErrorIn = true;
}

if (!ErrorIn)
{
    Console.WriteLine("Точка B! Координата Х");
    InData = checkdata.CheckInData(Console.ReadLine());
    if (InData.result) PointB.X = InData.inNumber;
        else ErrorIn = true;
}

if (!ErrorIn)
{
    Console.WriteLine("Точка B! Координата Y");
    InData = checkdata.CheckInData(Console.ReadLine());
    if (InData.result) PointB.Y = InData.inNumber;
        else ErrorIn = true;
}
if (!ErrorIn)
{
    Console.WriteLine("Точка B! Координата Z");
    InData = checkdata.CheckInData(Console.ReadLine());
    if (InData.result) PointB.Z = InData.inNumber;
       else ErrorIn = true;
}
if (!ErrorIn)
{
    double result = dz3.zadacha21(PointA, PointB);
    Console.WriteLine($"Результат задачи N21 {result:0.##}");
}
    else Console.WriteLine("Ошибка ввода, рассчет не будет выполнен, повторите ввод!");

//Задача 23
Console.WriteLine("Введите целое исходное число для задачи N23 от 1 .. N!, дробное значение будет усечено до целого!");
int innum=0; ErrorIn = false; 
    InData = checkdata.CheckInData(Console.ReadLine());
        if (InData.result) innum = (int)InData.inNumber;
            else ErrorIn = true;
if (!ErrorIn)
{
    if (innum > 0) Console.WriteLine($"" + dz3.zadacha23(innum));
        else Console.WriteLine("Введено нулевое либо отрицательное целое значение! Неверные критерии ввода!");
}
else Console.WriteLine("Ошибка ввода, рассчет не будет выполнен, повторите ввод!");

//Задача на полином до 16 цифр.
Console.WriteLine("Введите целое исходное число дo 16 цифр для поиска полинома!");
long fpolin=0; ErrorIn = false; 
    InData = checkdata.CheckInData(Console.ReadLine());
        if (InData.result) fpolin = (long)InData.inNumber;

        if (dz3.zadacha19full(fpolin)) Console.WriteLine("Число полином");
            else Console.WriteLine("Число не полином");