/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

//РЕШЕНИЕ ЗАДАЧИ:
/*
Console.Clear();
int FindSecondDigit(int number0)
{
int dec = number0 / 10;
int SecondDigit0 = dec % 10;
return SecondDigit0;
}
int number = new Random().Next(100, 1000);
int SecondDigit = FindSecondDigit(number);
Console.WriteLine($"The second digit of the number {number} is {SecondDigit}");
/*

/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

//РЕШЕНИЕ ЗАДАЧИ:
/*
Console.Clear();
//Следующий метод определяет разрядность введенного числа
int FindBitDepthNumber (int number0)
{
    int BitDepthNumber = 1;
    int divisor = 10;
    int divisible = number0;
    while (number0 / divisor > 0)
    {
        divisor = divisor * 10;
        BitDepthNumber++;
    }
    return BitDepthNumber;
}
//Следующий метод выдает третью цифру чисел, в которых разрядность больше или равна трем
int FindDigit(int number0, int BitDepthNumber0, int NumberDigit0)
{
    int degree = BitDepthNumber0 - NumberDigit0;
    int divisor = 1;
    int index = 0;
    while (index < degree)
    {
        divisor = divisor * 10;
        index++;
    }
    int DesiredDigit = (number0 / divisor) % 10;
    return DesiredDigit;
}
int NumberDigit = 3; //порядок цифры, которую хотим определить, по условию задачи - это третья цифра
Console.Write("Enter any positive integer number: ");
int number = Convert.ToInt32(Console.ReadLine());
int BitDepthNumber = FindBitDepthNumber(number);
if (BitDepthNumber < NumberDigit)
{
    Console.WriteLine($"The entered number {number} does NOT contain the third digit");
}
else
{
    int finddigit = FindDigit(number, BitDepthNumber, NumberDigit);
    Console.WriteLine($"The third digit of number {number} is {finddigit}");
}
*/

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
!!! Предполагается, что пользователь не ошибся и вводит число в диапазоне от 1 до 7
*/

//РЕШЕНИЕ ЗАДАЧИ:
/*
Console.Clear();
void Weekend (int numberDay0)
{
    if (numberDay0 < 6)
    {
        Console.WriteLine($"The entered day of the week {numberDay0} is NOT a weekend");
    } 
    else
    {
        Console.WriteLine($"The entered day of the week {numberDay0} is a weekend");
    }
}
Console.WriteLine("Enter the serial number of the day of the week (from 1 to 7): ");
int numberDay = Convert.ToInt32(Console.ReadLine());
Weekend (numberDay);
*/