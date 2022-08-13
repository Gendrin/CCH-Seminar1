using CID;
using DZ3;

TestInData checkdata = new TestInData();
TestInData.structInData InData;
dzSeminar3 dz3 = new dzSeminar3();

//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите целое пятизначное число!");

InData =checkdata.CheckInData(Console.ReadLine());

if (!InData.result) Console.WriteLine("Ввод данных неудачен необходимо повторить ввод данных!");
    else Console.WriteLine($"Введено значение {InData.inNumber}");
        if (InData.correct) Console.WriteLine("Произведена корректровка '.' на ','");
int test = (int)InData.inNumber;
int kolnumber = checkdata.checkKolNumber(test);

if (kolnumber != 5) Console.WriteLine($"Вы ввели не пятизначное число! -> : {test}");
else if (dz3.zadacha19(test)) Console.WriteLine("да");
    else Console.WriteLine("нет");
Console.WriteLine("Hello, World!");
