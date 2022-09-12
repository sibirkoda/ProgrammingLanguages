/* 
Задача №1. Задайте двумерный массив. 
Напишите программу, которая поменяет местами первую и последнюю строку массива.
Решение:

! СДЕЛАНО
*/

/*
Задача №2. Задайте двумерный массив.
Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
Решение:
*/
int [,] Create2dArray() //Метод создания двумерного массива m*n с нулевыми элементами 
{
    Console.WriteLine("To create an array of a given dimension, input:");
    Console.Write("- number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("- number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int [,] array = new int [rows, columns];

    for (int i=0; i< rows; i++)
    {
        for ( int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
    return array;
}

int [,] Create2dArray2(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i+1; j < array.GetLength(1); j++)
            {
                int temp = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = temp;
            }
    }
    return array;
}

void Print2dArray(int [,] array)//Печать двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

int [,] array =  Create2dArray();

Print2dArray(array);

Print2dArray(Create2dArray2(array));

/*
Задача №2. Из двумерного массива целых чисел удалить строку и столбец,
на пересечении которых расположен наименьший элемент.
* а) занулить б) сделать массив на 1 меньше
** минимальным элементом считать первый попавшийся элемент
Решение:
*/