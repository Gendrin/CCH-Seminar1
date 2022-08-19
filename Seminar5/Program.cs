using DZ5;
dz dz5 = new dz();
bool resultinLongArr;

Console.WriteLine("Please enter long array for task N 34!");

resultinLongArr = int.TryParse(Console.ReadLine(), out int longArray34);
int[] pArray34 = new int[longArray34];

if (resultinLongArr)
{
    pArray34 = dz5.GetRandomArray(longArray34,3,false);
    Console.WriteLine("Print quantity even elements random array!");
    dz5.PrintArray<int>(pArray34);
    Console.WriteLine($" -> {dz5.quantityEvenNumbers(pArray34)}");
}
else Console.WriteLine("No correct enter!");

Console.WriteLine("Please enter long array for task N 36!!");

resultinLongArr = int.TryParse(Console.ReadLine(), out int longArray36);
int[] pArray36 = new int[longArray36];

if (resultinLongArr)
{
    pArray36 = dz5.GetRandomArray(longArray36, 2, true);
    Console.WriteLine("Print Summ odd index elements random array!");
    dz5.PrintArray<int>(pArray36);
    Console.WriteLine($" -> {dz5.SumOddElementArray(pArray36)}");
}
else Console.WriteLine("No correct enter!");

Console.WriteLine("Please enter long array for task N 38!!");

resultinLongArr = int.TryParse(Console.ReadLine(), out int longArray38);
double[] pArray38 = new double[longArray38];

if (resultinLongArr)
{
    pArray38 = dz5.GetRandomArray(longArray38, 2.0, true);
    Console.WriteLine("Print Max - Min number array!");
    dz5.PrintArray<double>(pArray38);
    Console.WriteLine($" -> {dz5.MinAndMax(pArray38)}");
}
else Console.WriteLine("No correct enter!");

