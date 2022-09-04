Console.Clear();

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
//Решение:
/*
int [] CreateArray(int length0, int min0, int max0)
{
    int [] array0 = new int [length0];
    for (int index0 = 0; index0 < length0; index0++)
    {
        array0 [index0] = new Random().Next(min0, max0);
    }
    return array0;
}
int DigitEvenNumbers (int [] array0)
{
    int digitevennumbers = 0;
    int length0 = array0.Length;
    for (int index0 = 0; index0 < length0; index0++)
    {
        if (array0[index0] % 2 == 0)
        {
            digitevennumbers++;
        }
    }
    return digitevennumbers;
}
void PrintArray (int [] array0)
{
    for (int index0 = 0; index0 < array0.Length; index0++)
    {
        Console.Write($"{array0 [index0]} ");
    }
}
Console.WriteLine("Input the array size from 3 to 10");
int length = Convert.ToInt32(Console.ReadLine());
int [] array = CreateArray(length, 100, 1000);
Console.Write("The number of even numbers in the array [");
PrintArray(array);
Console.WriteLine($"] is {DigitEvenNumbers(array)}");
*/




//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
//Решение:
/*
int [] CreateArray(int length0, int min0, int max0)
{
    int [] array0 = new int [length0];
    for (int index0 = 0; index0 < length0; index0++)
    {
        array0 [index0] = new Random().Next(min0, max0);
    }
    return array0;
}
int FindSum (int [] array0)
{
    int findsum = 0;
    int length0 = array0.Length;
    for (int index0 = 0; index0 < length0; index0+=2)
    {
        findsum += array0 [index0];
    }
    return findsum;
}
void PrintArray (int [] array0)
{
    for (int index0 = 0; index0 < array0.Length; index0++)
    {
        Console.Write($"{array0 [index0]} ");
    }
}
Console.WriteLine("Input the array size from 2 to 15");
int length = Convert.ToInt32(Console.ReadLine());
int [] array = CreateArray(length, -100, 100);
Console.Write("The sum of the odd elements of the array [");
PrintArray(array);
Console.WriteLine($"] is {FindSum(array)}");
*/



//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
/*
void PrintArray (double [] array0)
{
    for (int index0 = 0; index0 < array0.Length; index0++)
    {
        Console.Write($"{array0 [index0]} ");
    }
}
double [] CreateArray(int length0, int min0, int max0)
{
    double [] array1 = new double [length0];
    for (int index0 = 0; index0 < length0; index0++)
    {
        array1 [index0] = Convert.ToDouble(new Random().Next(min0, max0));
    }
    return array1;
}
double FindMin (double [] array0)
{
    double min = array0 [0];
    int length0 = array0.Length;
    for (int index0 = 0; index0 < length0; index0++)
    {
        if (array0[index0] < min) 
        {
            min = array0[index0];
        }
    }
    return min;
}
double FindMax (double [] array0)
{
    double max = array0 [0];
    int length0 = array0.Length;
    for (int index0 = 0; index0 < length0; index0++)
    {
        if (array0[index0] > max) 
        {
            max = array0[index0];
        }
    }
    return max;
}
Console.WriteLine("Input the array size from 2 to 15");
int length = Convert.ToInt32(Console.ReadLine());
double [] array = CreateArray(length, 0, 100);
double difference =  FindMax(array) - FindMin(array);
Console.Write("The difference between the maximum and minimum elements of the array [");
PrintArray(array);
Console.WriteLine($"] is {difference}");
*/