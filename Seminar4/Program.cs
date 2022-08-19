using DZ4;

dz dz4 = new dz();

// Задача N 25
bool resultinA, resultinB;
Console.WriteLine("Please enter fierst number!");
resultinA = int.TryParse(Console.ReadLine(), out int a);
Console.WriteLine("Please enter second number!");
resultinB = int.TryParse(Console.ReadLine(), out int b);

if (resultinA && resultinB)

        {
            Console.WriteLine($"In numbers {a} {b}");
            Console.WriteLine($"Result {a},{b} -> {dz4.degryAinB(a, b)} ({a} in degree {b})");
        }
        else Console.WriteLine("No correct enter!");

// Задача N 27
Console.WriteLine("Please enter number for numerology!");
resultinA = int.TryParse(Console.ReadLine(),out int aa);
if (resultinA)

        {
            Console.WriteLine($"Enter number {aa}");
            Console.WriteLine($"Result enter number {aa} -> {dz4.numerology(aa)} result numerology ");
        }

        else Console.WriteLine("No correct enter!");

// Задача N 29
bool resultinLongArr;

Console.WriteLine("Please enter long array!");

resultinLongArr = int.TryParse(Console.ReadLine(), out int longArray);
int[] pArray = new int[longArray];

        if (resultinLongArr)
        {
            pArray = dz4.GetRandomArray(longArray);
        }
            else Console.WriteLine("No correct enter!");

Console.WriteLine("Print elements random array!");
dz4.PrintArray(pArray);

