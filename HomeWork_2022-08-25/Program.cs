/*
Задача №19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
Решение:
*/

/*
Console.Clear();
//В этом методе определяем разрядность введенного числа (на основе полученного числа в следующем методе создадим массив соответствующего размера):
int DigitNumber (int number0)
{
    int divider = 10;
    int digitnumber = 1;
    while (number0 / divider > 0)
    {
        divider = divider * 10;
        digitnumber++;
    }
    return digitnumber;
}

// В этом методе создаем массив, элементы которого соответствуют цифрам вводимого целого числа
int [] Massiv (int number0, int digitnumber0)
{
    int [] massiv0 = new int [digitnumber0];
    int divisible = number0;
    int index = 1;
    while (index - 1 < digitnumber0)
    {
        massiv0 [digitnumber0 - index] = divisible % 10;
        divisible = divisible / 10;
        index ++;
    }
    return massiv0;
}

//Этот проверяет массив на симметричность, выдает false либо true - в зависимости от симмтеричности
bool SymmetryMassiv (int [] array0)
{
    int length = array0.Length;
    int index0 = 0;
    bool symmetrymassiv = true;
    while (index0 < length / 2)
    {
        if (array0[index0] == array0[length - 1 - index0])
        {
            index0++;
        }
        else
        {
            symmetrymassiv = false;
            break;
        }
    }
    return symmetrymassiv;
}

Console.Write("Input positive integer number: ");
int number = Convert.ToInt32(Console.ReadLine()); // получаем число от пользователя

int digitnumber = DigitNumber (number); //определяем разрядность числа
int [] massiv = Massiv (number, digitnumber); // преобразуем число в массив из цифр числа

if (SymmetryMassiv(massiv)) //если метод Massiv дает true, то массив симметричен, а значит число палиндром, ну и наоборот
{
    Console.WriteLine($"The entered number {number} is a palindrome");
}
else
{
    Console.WriteLine($"The entered number {number} is NOT a palindrome");
}
*/

/*
Задача №21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
Решение
*/

/*
Console.Clear();
Console.Write("Enter the X coordinate of point A: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the Y coordinate of point A: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the Z coordinate of point A: ");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the X coordinate of point B: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the Y coordinate of point B: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the Z coordinate of point B: ");
double z2 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.Write($"The distance between points A({x1}, {y1}, {z1}) and B({x2}, {y2}, {z2}) is {distance}");
*/

/*
Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
Решение:
*/

/*
Console.Clear();
//Метод, выводящий кубы чисел от 1 до введенного пользователем числа
void table (int number0)
{
    int index0 = 1; 
    while (index0 < number0 + 1)
    {
        Console.Write($"{Math.Pow(index0, 3)}, ");
        index0++;
    }
}

Console.Write("Enter a positive integer: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The table of cubes of numbers in the range from 1 to {number} looks like this:");
table (number);
*/