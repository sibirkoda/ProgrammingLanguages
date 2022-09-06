Console.Clear();

/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

// Решение (1-й способ - путем ввода чисел по одному через Enter)

/*
double [] CreateArray () //Метод создания массива на основе введенных чисел пользователем
{
    Console.Write("Input the number of numbers you plan to enter: ");
    int M = Convert.ToInt32(Console.ReadLine());
    double [] array0 = new double [M];
    for (int index = 0; index < M; index++)
    {
        Console.Write($"Input the numbers #{index + 1}: ");
        array0 [index] = Convert.ToInt32(Console.ReadLine());
    }
    return array0;
}
int FindNumberPositive (double [] array0) // Метод определяющий число положительных чисел в массиве
{
    int numberpositive = 0;
    for (int index = 0; index < array0.Length; index++)
    {
        if (array0[index] > 0) numberpositive++; 
    }
    return numberpositive;
}
void PrintArray (double [] array0) // Метод, печатающий массив в строку
{
    Console.Write("(");
    for (int index = 0; index < array0.Length - 1; index++)
    {
        Console.Write($"{ array0 [index] }, ");
    }
    Console.Write($"{array0 [array0.Length - 1]})");
}
Console.WriteLine(); //пропускаем строку пустую
double [] array = CreateArray ();
Console.Write("The number of positive numbers among the inputed "); // Вывод на экран числа положительных чисел
PrintArray(array);
Console.Write($" is {FindNumberPositive(array)}");
*/

// Решение (2-й способ - путем ввода чисел через пробел в одной строке)

/*
void PrintArray (double [] array0) // Метод, печатающий массив в строку
{
    Console.Write("(");
    for (int index = 0; index < array0.Length - 1; index++)
    {
        Console.Write($"{ array0 [index] }, ");
    }
    Console.Write($"{array0 [array0.Length - 1]})");
}
int FindNumberPositive (double [] array0) // Метод определяющий число положительных чисел в массиве
{
    int numberpositive = 0;
    for (int index = 0; index < array0.Length; index++)
    {
        if (array0[index] > 0) numberpositive++; 
    }
    return numberpositive;
}
Console.Write("Input the numbers separated by a space: ");
double [] array = Array.ConvertAll(Console.ReadLine().Split(), Double.Parse);
Console.Write("The number of positive numbers among the inputed "); // Вывод на экран числа положительных чисел
PrintArray(array);
Console.Write($" is {FindNumberPositive(array)}");
*/




/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
// Решение:
/*
Console.WriteLine("Two straight lines given by the equations are given:");
Console.WriteLine("y = k1 * x + b1, y = k2 * x + b2");
double [,] coef = new double [2,2]; //создаем матрицу размера 2*2, будем хранить в ней коэффициенты из уравнения
Console.WriteLine("Enter the coefficient k1: ");
coef [0,0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the coefficient b1: ");
coef [0,1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the coefficient k2: ");
coef [1,0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the coefficient b2: ");
coef [1,1] = Convert.ToInt32(Console.ReadLine());
double FindX (double [,] coef0)//используем формулу решения системы двух урравнений: x=(b1-b2)/(k2-k1)
{
    double x = (coef[0,1]-coef[1,1])/(coef[1,0]-coef[0,0]);
    return x;    
}
double FindY (double [,] coef0)//используем формулу решения системы двух урравнений: y=(k2*b1-k1*b2)/(k2-k1)
{
    double y = (coef[1,0]*coef[0,1]-coef[0,0]*coef[1,1])/(coef[1,0]-coef[0,0]);
    return y;
}
void PrintSolution(double [,] array0)
{
    if (array0[0,0] == array0[1,0]) 
    {
        if (array0[0,1] == array0[1,1]) Console.WriteLine("There are infinitely many common points, the lines coincide");
        else Console.WriteLine("There are no common points, straight parallel");
    }
    else 
    {
        double x = FindX (array0);
        double y = FindY (array0);
        Console.WriteLine($"{x} и {y}");
    }
}
PrintSolution(coef);
*/