int EnterNumber(string number)
{
    Console.Write($"Enter {number}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}





// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine();
Console.WriteLine("Задача 25");
Console.WriteLine();

int numA = EnterNumber("Number A");
int numB = EnterNumber("Number B");
int Result = 1;

for (int i = 0; i < numB; i++)
    {
        Result = Result*numA;
    }

Console.WriteLine($"Result = {Result}");
Console.WriteLine();
Console.WriteLine("************");



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigitalInNumber(int number)
{
    int sum = 0;
    
    for (int i = 10; number > 0; number = number / i)
    {
        int temp = number % i;
        sum = sum + temp;

    }
    return sum;
}
    

Console.WriteLine();
Console.WriteLine("Задача 27");
Console.WriteLine();

int num = EnterNumber("Number");
Result = SumDigitalInNumber(num);
Console.WriteLine();
Console.WriteLine($"Sum of digitals = {Result}");

Console.WriteLine();
Console.WriteLine("************");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


int [] CreateArray(int size, int minValue, int maxValue)
{
    int [] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i=0; i<count; i++)
    {
        Console.Write($"{array[i]}"+" ");
    }
    Console.WriteLine();
}


Console.WriteLine();
Console.WriteLine("Задача 29");
Console.WriteLine();


int minValue = EnterNumber("Enter minValue for array");
int maxValue = EnterNumber("Enter maxValue for array");

Console.WriteLine();

int [] someArray = CreateArray(8, minValue, maxValue);

PrintArray(someArray);

