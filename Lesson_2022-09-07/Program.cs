using System.Linq;

string text = "(1,2) (2,3) (3,4) (4,5)"
            .Replace("(", "")
            .Replace(")", "");

/// 

var data = text.Split(" ")
            .Select(item => item.Split(","))
            .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
            .Where(e => e.x % 2 == 0)
            .Select(point => (point.x * 10, point.y))
            .ToArray();
for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
    Console.WriteLine();
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

