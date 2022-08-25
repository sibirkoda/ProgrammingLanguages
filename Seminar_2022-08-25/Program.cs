// Задача №1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
Console.Clear();
int Quadrant (double X0, double y0)
{
    if (X0 > 0 && y0 > 0) return 1;
    if (X0 > 0 && y0 < 0) return 4;
    if (X0 < 0 && y0 > 0) return 2;
    if (X0 < 0 && y0 < 0) return 3;
    return 0;
}
Console.WriteLine ("Input X coordinate:");
double X = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Input Y coordinate:");
double y = Convert.ToDouble(Console.ReadLine());
int quadrant = Quadrant (X, y);
Console.WriteLine ($"Number qudrant is {quadrant}");
*/

/*
Задача №2. Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
*/
/*Console.Clear();
void Diapasone (int quadrant0)
{
    if (quadrant0 == 1) Console.WriteLine ("Переменные x и y - положительные");
    if (quadrant0 == 2) Console.WriteLine ("Переменные x - отрицательное, y - положительные");
    if (quadrant0 == 3) Console.WriteLine ("Переменные x - отрицательное, y - отрицательные");
    if (quadrant0 == 4) Console.WriteLine ("Переменные x - положительные, y - отрицательные");

}
Console.WriteLine ("Input number quadrant:");
int quadrant = Convert.ToInt32(Console.ReadLine());
Diapasone(quadrant);
*/

// Задача №3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
/*
Console.Clear();
void quadrat(int n0)
{
    int index = 1;
    while (index < n0 + 1)
    {
        Console.WriteLine (index*index);
        index++;
    }
}
Console.WriteLine ("Input number:");
int number = Convert.ToInt32(Console.ReadLine());
quadrat(number);
*/

// Задача №4. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

/*
Console.Clear();
Console.WriteLine ("Input XA coordinate:");
double XA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Input YA coordinate:");
double YA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Input XB coordinate:");
double XB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Input YB coordinate:");
double YB = Convert.ToDouble(Console.ReadLine());
double Metr (double xa, double ya, double xb, double yb)
{
    return Math.Sqrt((xb-xa)*(xb-xa)+(yb-ya)*(yb-ya));
}
double metr = Metr (XA, YA, XB, YB);
Console.WriteLine ($"Metr is {metr}");
*/