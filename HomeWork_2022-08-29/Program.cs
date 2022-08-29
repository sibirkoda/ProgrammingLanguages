Console.Clear ();

/*
Задача №25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
Решение:
*/

/*
Console.Write ("Input the first number A: ");
double numberA = Convert.ToDouble(Console.ReadLine());
Console.Write ("Input the second number B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

double FindDegree (double numberA0, int numberB0)
{
    double finddegree = numberA0;
    for (int index = 2; index <= numberB0; index++)
    {
        finddegree = finddegree * numberA0;
    }
    return finddegree;
}
Console.WriteLine ($"Number {numberA} to the power {numberB} is {FindDegree(numberA, numberB)}");
*/

/*
Задача №27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
Решение:
*/
/*
int FindSum(string number0)
{
    int lengthDigit = number0.Length;
    int numberInt = Convert.ToInt32((number0));
    int findsum = 0;

    for (int index = 0; index < lengthDigit; index++)
    {
        findsum = findsum + numberInt % 10;
        numberInt = numberInt / 10;
    }

    return findsum;
}
Console.Write ("Input the positive integer number: ");
string number = Console.ReadLine();
Console.WriteLine ($"The sum of the digits of the number {number} is {FindSum(number)}");
*/

/* Задача №29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
Решение:
*/
/*
void Array (int size0)
{
    int [] array = new int [size0];
    for (int index = 0; index < size0; index++)
    {
        Console.Write ($"Input an array element with index #{index}: ");
        array[index] = Convert.ToInt32(Console.ReadLine());
    }

    Console.Write ("You have entered the following array: [");
    for (int index = 0; index < size0 - 1; index++)
    {
        Console.Write ($"{array[index]}, ");
    }
    Console.Write ($"{array[size0-1]}]");
}
Console.Write ("Input the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
Array(size);
*/