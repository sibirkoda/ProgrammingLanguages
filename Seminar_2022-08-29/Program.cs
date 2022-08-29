// Задача №1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int FindSumm (int a)
{
    int sum = 0;
    for (int index = 1; index <= a; index++ )
    sum += index;
    return sum;
}
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindSumm(n));
*/

// Задача №2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
Console.Clear();
Console.Write("Введите число: ");
string number = Console.ReadLine();

int DigitNumber (string number0)
{
    int digitnumber = number0.Length;
    return digitnumber;
}
Console.WriteLine(DigitNumber(number));
*/

// Задача №3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int FindComp (int number0)
{
    int comp = 1;
    for (int index = 1; index <= number0; index++ )
    comp = comp * index;
    return comp;
}
Console.WriteLine(FindComp (number));
*/

// Задача №4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
/*
Console.Clear();
int [] TrArray (int [] array0, int lengthArray0)
{
    int index = 0;
    for (index = 0; index < lengthArray0; index++)
    {
        array0 [index] = new Random().Next(0, 2);
    }
    return array0;
}
void PrintArray (int [] array0, int lengthArray0)
{
    int index = 0;
    for (index = 0; index < lengthArray0; index++)
    Console.WriteLine(array0 [index]);
}

int lengthArray = 5;
int [] array = new int [lengthArray];
array = TrArray (array, lengthArray);
PrintArray (array, lengthArray);
*/