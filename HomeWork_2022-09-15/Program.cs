Console.Clear();

/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""

Решение*/
/*
// Получаем числа от пользователя
Console.WriteLine("Input a range of natural numbers:");
Console.Write("- the first number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("- the second number: ");
int max = Convert.ToInt32(Console.ReadLine());

if (min > max)
{
    int temp = max;
    max = min;
    min = temp;
}

// Рекурсия
void ShowNumbers(int min, int max)
{
    if (max > min ) ShowNumbers(min, max -1 );
    Console.Write(max + " ");
}

Console.WriteLine($"The following natural numbers belong to the interval [{min}, {max}]:");
ShowNumbers(min, max);
*/






/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
Решение:
*/
/*
// Получаем числа от пользователя
Console.WriteLine("Input a range of natural numbers:");
Console.Write("- the first number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("- the second number: ");
int max = Convert.ToInt32(Console.ReadLine());

if (min > max)
{
    int temp = max;
    max = min;
    min = temp;
}

// Рекурсия
int ShowNumbers(int min, int max)
{
    int sum = max;
    if (max > min)
    {
        sum = sum + ShowNumbers(min, max - 1);
    }
    return sum;
}

Console.Write($"The sum of the natural numbers in the interval [{min}, {max}] is: ");
Console.Write(ShowNumbers(min, max));
*/






/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
Решение:
*/

/*
// Получаем числа от пользователя
Console.Write("Input the first number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: ");
int n = Convert.ToInt32(Console.ReadLine());

// Рекурсия
int FuncAccer(int m, int n)
{
    int funcAccer = 1;

    if (m == 0)
        return funcAccer = n + 1;
    else
    {
        if (n > 0)
            return funcAccer = FuncAccer(m - 1, FuncAccer(m, n - 1));
        else
            return FuncAccer(m - 1, 1);
    }
}

Console.Write($"The Ackerman function of numbers {m} and {n} is : ");
Console.Write(FuncAccer(m, n));
*/