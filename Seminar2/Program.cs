﻿//namespace seminar2;
using CID;
using DZ2;
// Подкотавливваем структуру и метод для проверки исходных данных.
checkInData checkdata = new checkInData();

checkInData.structInData InData;
dzSeminar2 dz2 = new dzSeminar2();
//Задача №10
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает
// вторую цифру этого числа.
Console.WriteLine("Задание №10. Введите трехзначное целое число!");

InData =checkdata.CheckInData(Console.ReadLine());

if (!InData.result) Console.WriteLine("Ввод данных неудачен необходимо повторить ввод данных!");
    else Console.WriteLine($"Введено значение {InData.inNumber}");
        if (InData.correct) Console.WriteLine("Произведена корректровка '.' на ','");
int test = (int)InData.inNumber;

if (checkdata.checkKolNumber(test)!=3) Console.WriteLine("Введенное число не трехзначное целое! Работа программы прекращена.");
    else Console.WriteLine($"вторая цифра в числе = {dz2.zadacha10(test)}");

//Задача №13
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//что третьей цифры нет.


Console.WriteLine("Hello, World!");
