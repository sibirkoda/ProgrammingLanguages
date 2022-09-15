Console.Clear();
/*
Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочить по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

Решение
*/
/*
int[,] Create2dArray() //Метод создания и заполнения двумерного массива m*n 
{
    Console.WriteLine("To create an array of a given dimension, input:");
    Console.Write("- number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("- number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];

    Console.WriteLine("Define the range of values of the array elements: ");
    Console.Write("- minimum value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("- maximum value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void Print2dArray(int[,] array)//Печать двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

int[,] SortingRows(int[,] array) // метод упорядочивания элементов в строках
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - j -1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    return array;
}


int[,] array = Create2dArray();
Print2dArray(array);
Console.WriteLine();

Console.WriteLine("Sorted array in descending order is:");
Print2dArray(SortingRows(array));
*/



/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Решение:
*/
/*
//Метод создания и заполнения двумерного массива m*n
int[,] Create2dArray()
{
    Console.WriteLine("To create an array of a given dimension, input:");
    Console.Write("- number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("- number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];

    Console.WriteLine("Define the range of values of the array elements: ");
    Console.Write("- minimum value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("- maximum value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

// Метод выдает номер строки с наименьшей суммой
void NumberRows(int[,] array)
{
    //заполняем одномерный массив суммй элементов в строке
    int[] arraySum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arraySum[i] = arraySum[i] + array[i, j];
        }
    }

    int index = 0;
    int min = arraySum[0];

    for (int i = 0; i < arraySum.GetLength(0) - 1; i++)
    {

        if (min > arraySum[i + 1])
        {
            min = arraySum[i + 1];
            index = i + 1;
        }
    }
    
    Console.WriteLine($"The minimum amount is in the row with the index {index}");
}

//Печать двумерного массива
void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

int[,] array = Create2dArray();
Print2dArray(array);
Console.WriteLine();
NumberRows(array);
*/




/*
Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
Решение:
*/

/*
//Метод создания и заполнения двумерного массива m*n
int[,] Create2dArray()
{
    Console.Write("- number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("- number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

//Метод усножения двух матриц
int[,] MatrixMult(int[,] arrayOne, int[,] arraySecond)
{
    int[,] array = new int[arrayOne.GetLength(0), arraySecond.GetLength(1)];
    for (int i = 0; i < arrayOne.GetLength(0); i++)
    {
        for (int j = 0; j < arraySecond.GetLength(1); j++)
        {
            for (int k = 0; k < arrayOne.GetLength(1); k++)
            {
                array[i,j] +=  arrayOne[i,k] * arraySecond[k,j];
            }
        }
    }
    return array;
}

//Печать двумерного массива
void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

Console.WriteLine("To create the FIRST array of a given dimension, enter:");
int[,] array1 = Create2dArray();
Console.WriteLine("To create a SECOND array of a given dimension, enter:");
int[,] array2 = Create2dArray();
Console.WriteLine();
Console.WriteLine("!!! We inform you that for simplicity, array elements take values in the range from 1 to 10");
Console.WriteLine();

Console.WriteLine("FIRST array:");
Print2dArray(array1);
Console.WriteLine();
Console.WriteLine("SECOND array:");
Print2dArray(array2);
Console.WriteLine();

if (array1.GetLength(1) != array2.GetLength(0))
    Console.WriteLine("Matrices cannot be multiplied");
else 
{
    int[,] array =  MatrixMult(array1, array2 );
    Console.WriteLine("Product of matrices:");
    Print2dArray(array);
}
*/





/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

Решение:
*/

//Метод создания и заполнения трехмерного массива
int[,,] Create3dArray()
{
    Console.WriteLine("To create an array of a given dimension, input:");
    Console.Write("- number of elements with index 0: ");
    int index0 = Convert.ToInt32(Console.ReadLine());
    Console.Write("- number of elements with index 1: ");
    int index1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("- tnumber of elements with index 2: ");
    int index2 = Convert.ToInt32(Console.ReadLine());

    int[,,] array = new int[index0, index1, index2];

    int beginDigit = 10;
    int l = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = beginDigit + l;
                l++;
            }
        }
    }
    return array;
}

//Печать трехмерного массива
void Print3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                string SetIndex = "(" + Convert.ToString(i) + ", " + Convert.ToString(j) + ", " + Convert.ToString(k) + ")";
                Console.Write($"{array[i, j, k]} {SetIndex}   ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] array3d = Create3dArray();
Print3dArray(array3d);

/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

//Метод создания двумерного массива m*n с нулевыми значениями
int[,] Create2dArray()  
{
    Console.WriteLine("To create an array of a given dimension, input:");
    Console.Write("- number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("- number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    return array;
}

int[,] Fil2dArray(int [,] array)
{
    int count = 10;

    int [,] filarray = new int [array.GetLength(0), array.GetLength(1)];
    filarray[0,0] = count;

    int beginrows = 0;
    int begincolumns =0;

    int endrows = array.GetLength(0);
    int endcolumns = array.GetLength(1);
    
    
    
    return array;
}

//Печать двумерного массива
void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}