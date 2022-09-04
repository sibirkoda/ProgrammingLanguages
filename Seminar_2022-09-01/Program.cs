Console.Clear();

// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных элементов массива.
/*
int [] array = new int [12];
int [] Array (int [] array0)
{
    int LengthArray0 = array0.Length;
    for (int index = 0; index < LengthArray0; index++)
    {
        array0 [index] = new Random().Next(-9, 10);
    }
        return array0;
}
int SumNeg (int [] array0)
{
    int sumneg0 = 0;
    int LengthArray0 = array0.Length;
    for (int index = 0; index < LengthArray0; index++)
    {
        if (array0[index] < 0)
        {
            sumneg0 = sumneg0 + array0[index];
        }
    }
    return sumneg0;
}

int LengthArray = array.Length;
Array (array);
for (int index = 0; index < LengthArray; index++)
    {
        Console.Write($"{array [index]} ");
    } 
Console.WriteLine();
Console.WriteLine(SumNeg(array));
*/



//Задача №1. Напишите программу для замены элементов массива: положительные элементы замените на соответствующие отрицательные, 
//и наоборот.
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
int [] ChangeArray(int [] array0)
{
    for (int index0 = 0; index0 < array0.Length; index0++)
    {
        if (array0 [index0] > 0)
        {
            array0 [index0] = array0 [index0] * (-1);
        }
    }
    return array0;
}
void PrintArray (int [] array0)
{
    for (int index0 = 0; index0 < array0.Length; index0++)
    {
        Console.Write($"{array0 [index0]} ");
    }
}
int length = 10;
int [] array = CreateArray (length, -10, 10);
PrintArray (array);
Console.WriteLine();
ChangeArray (array);
PrintArray (array);
*/

//Задача №2. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
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

void FindNumber (int [] array0, int number0)
{
    for (int index0 = 0; index0 < array0.Length; index0++)
    {
        if (array0 [index0] == number0)
        {
            Console.WriteLine("Искомое число в массиве есть");
            break;
        }
    }
}

void PrintArray (int [] array0)
{
    for (int index0 = 0; index0 < array0.Length; index0++)
    {
        Console.Write($"{array0 [index0]} ");
    }
}

int number = new Random().Next(1, 10);
Console.WriteLine(number);

int length = 10;
int [] array = CreateArray (length, 1, 10);
PrintArray (array);
Console.WriteLine();
FindNumber (array, number);
*/


//Задача №3. Задайте одномерный массив из 15 случайных чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99].
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

int DigitNumber(int [] array0, int min0, int max0)
{
    int digitnumber = 0;
    for (int index0 = 0; index0 < array0.Length; index0++)
    {
        if (array0 [index0] > min0 - 1)
        {
            if (array0 [index0] < max0 + 1)
                {
                    digitnumber++;
                }
        } 
    }
    return digitnumber;
}

void PrintArray (int [] array0)
{
    for (int index0 = 0; index0 < array0.Length; index0++)
    {
        Console.Write($"{array0 [index0]} ");
    }
}

int length = 15;
int [] array = CreateArray (length, 1, 150);
PrintArray (array);
Console.WriteLine();
Console.WriteLine(DigitNumber(array, 10, 99));
*/

//Задача №4. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
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

int [] CreateArray2(int [] array0)
{
    int length0 = array0.Length/2;
    int [] array1 = new int [length0];
    for (int index0 = 0; index0 < length0; index0++)
    {
        array1[index0] = array0[index0] * array0[array0.Length - 1 - index0];
    }
    return array1;
}

void PrintArray (int [] array0)
{
    for (int index0 = 0; index0 < array0.Length; index0++)
    {
        Console.Write($"{array0 [index0]} ");
    }
}

int length = 9;
int [] array = CreateArray (length, 1, 10);
PrintArray (array);
Console.WriteLine();
int [] array1 = CreateArray2 (array);
PrintArray (array1);
*/