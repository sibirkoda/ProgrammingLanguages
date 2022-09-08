Console.Clear();
// Задача №1. Задайте двумерный массив размером m×n, заполненный случайными целыми числами
/*
int [,] CreateRandom2dArray ()
{
    Console.WriteLine("Inpur numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Inpur numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Inpur min numbers: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Inpur max numbers: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int [,] newArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray [i, j] = new Random().Next(minValue, maxValue);
    return newArray;
}
void Show2dArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write($"{array[i,j]} ");
        Console.WriteLine();
        }
    Console.WriteLine();
}
int [,] array = CreateRandom2dArray();
Show2dArray (array);
*/

//Задача №2. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. 
// Выведите полученный массив на экран.
int [,] CreateRandom2dArray ()
{
    Console.WriteLine("Inpur numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Inpur numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Inpur min numbers: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Inpur max numbers: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int [,] newArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray [i, j] = i+j;
    return newArray;
}
void Show2dArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write($"{array[i,j]} ");
        Console.WriteLine();
        }
    Console.WriteLine();
}
int [,] array = CreateRandom2dArray();
Show2dArray (array);

//Задача №3. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

//Задача №4. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.


