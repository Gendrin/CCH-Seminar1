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
int test = (int)InData.inNumber;
int kolnumber = checkdata.checkKolNumber(test);

dzseminar3 dz3 = new dzseminar3();


if (kolnumber != 5) Console.WriteLine($"Вы ввели не пятизначное число! -> : {test}");
else if (dz3.zadacha19(test)) Console.WriteLine("да");
    else Console.WriteLine("нет");


