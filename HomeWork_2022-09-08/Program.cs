Console.Clear();
/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
//Решение

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

//Создание трехмерного массива m*n*1 из двумерного массива m*n, 
//где третья размерность - соответствует разрядности элемента

double [,,] Create3dArray(double [,] array)//[,,1] - число знаков ДО запятой, [,,2] - число знаков после запятой
{
    double [,,] array3d = new double [array.GetLength(0), array.GetLength(1),3];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            {
                array3d[i,j,0] = array[i,j];
                // число знаков после запятой
                int index = 0;
                while (array[i,j] * Math.Pow(10, 1 + index) % 10 != 0)
                {
                    index++;
                }
                array3d[i,j,1] = index;
            }
    return array3d;
}


//Печать двумерного массива
void Print2dArray (double [,] array)
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
//Печать двумерного массива

void Print3dArray (double [,,] array)
{
    //определение максимальной разрядности элементов
    //int digitnumber = 1
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j,1]} ");
            Console.WriteLine();
        }
}

double [,] array2d = Fil2dArray(Create2dArray());
Print2dArray(array2d);

Print3dArray(Create3dArray(array2d));



/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/