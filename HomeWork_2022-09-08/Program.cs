Console.Clear();
/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
//Решение
/*
double [,] Create2dArray() //Метод создания двумерного массива m*n с нулевыми элементами размером 
{
Console.WriteLine("To create an array of a given dimension, input:");
Console.Write("- number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("- number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
double [,] array = new double [rows, columns];
return array;
}

double [,] Fil2dArray (double [,] array) //Заполнение двумерного массива m*n случайными вещественными числами
{
    Console.WriteLine("Define the range of values of the array elements: ");
    Console.Write("- minimum value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("- maximum value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the number of digits after the decimal point in the values of the array elements: ");
    int numberdigit = Convert.ToInt32(Console.ReadLine());
    
    for (int i = 0; i < array.GetLength(0); i++)//ниже определяем алгоритм, чтобы было нужно число знаков после запятой 
        for (int j = 0; j < array.GetLength(1); j++)
           {
                int min = minValue;
                int max = maxValue;
                int dec = 1;
                for (int index = 0; index < numberdigit; index++)
                {
                    min = min * 10;
                    max = max * 10;
                    dec = dec * 10;
                }
                array [i,j] = (double) (new Random().Next(min, max)) / dec;
           }
    return array;
}

void Print2dArray (double [,] array)//Печать двумерного массива
{
    //определение максимальной разрядности элементов
    //int digitnumber = 1
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j]} ");
            Console.WriteLine();
        }
}

Print2dArray(Fil2dArray(Create2dArray()));
*/


/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
//Решение
/*
int [,] Create2dArray() //Метод создания двумерного массива m*n с нулевыми элементами размером 
{
Console.WriteLine("To create an array of a given dimension, input:");
Console.Write("- number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("- number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [rows, columns];
return array;
}

int [,] Fil2dArray (int [,] array) //Заполнение двумерного массива m*n случайными целыми числами
{
    Console.WriteLine("Define the range of values of the array elements: ");
    Console.Write("- minimum value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("- maximum value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
        
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
           array [i,j] = new Random().Next(minValue, maxValue);
    return array;
}

void Print2dArray (int [,] array)//Печать двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j]} ");
            Console.WriteLine();
        }
}

void FindElement (int [,] array)
{
    Console.WriteLine("Input the row and column numbers of the array element you are looking for:");
    Console.Write("- number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("- number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("In the array:");
    Print2dArray(array);
    
    if (rows < array.GetLength(0)+1)
        {
            if (columns < array.GetLength(1)+1)
            {
                Console.WriteLine($"the element in row {rows} and column {columns} is {array[rows-1, columns-1]}");
            }
            else Console.WriteLine("element with such numbers does not exist");
        }
    else Console.WriteLine("element with such numbers does not exist");
}

FindElement(Fil2dArray(Create2dArray()));
/*

/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
//Решение:
/*
int [,] Create2dArray() //Метод создания двумерного массива m*n с нулевыми элементами размером 
{
Console.WriteLine("To create an array of a given dimension, input:");
Console.Write("- number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("- number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [rows, columns];
return array;
}

int [,] Fil2dArray (int [,] array) //Заполнение двумерного массива m*n случайными целыми числами
{
    Console.WriteLine("Define the range of values of the array elements: ");
    Console.Write("- minimum value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("- maximum value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
        
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
           array [i,j] = new Random().Next(minValue, maxValue);
    return array;
}

double [] ArithMean (int [,] array2d)// заполнение одномерного массива значениями, равными ср. арифмет. от столбцов двумерного массива
{
    double [] arithmean = new double [array2d.GetLength(1)];
    for (int j = 0; j < array2d.GetLength(1); j++)
            {
                double sum = 0;
                for (int i=0; i < array2d.GetLength(0); i++)
                {
                    sum += array2d [i,j]; 
                }
                arithmean[j] = (double) sum / array2d.GetLength(0);
            }
    return arithmean;
}

void Print2dArray (int [,] array)//Печать двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j]} ");
            Console.WriteLine();
        }
}

void Print1dArray (double [] array)//печать одномерного массива
{
    Console.Write("(");
    for (int i = 0; i < array.Length-1; i++)
       {
        Console.Write($"{Math.Round(array[i], 2)}; ");
       }
    Console.Write($"{Math.Round(array[array.Length-1], 2)})");
    
}

int [,] array2d = Fil2dArray(Create2dArray());
Console.WriteLine("In the array:");
Print2dArray(array2d);
double [] array1d = ArithMean(array2d);
Console.Write("The arithmetic mean values of the columns are equal to: ");
Print1dArray(array1d);
*/