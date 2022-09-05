Console.Clear();
/*
string [,] table = new string [2, 5];
// table[0 , 0] .. table [0, 4]
// table[1 , 0] .. table [1, 4]
for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        table[rows, columns] = Convert.ToString(rows + columns);
    }
}
table [1, 2] = "слово";
for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine(table[rows, columns]);
    }
}
*/

/*
int [,] matrix = new int [3, 4];
for (int rows = 0; rows < matrix.GetLength(0); rows++)
{
    for (int columns = 0; columns < matrix.GetLength(1); columns++)
    {
        Console.Write($"{matrix [rows, columns]} ");
    }
    Console.WriteLine();
}
*/
/*
int [,] FillingMatrix (int [,] matrix0)
{
    for (int rows = 0; rows < matrix0.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix0.GetLength(1); columns++)
        {
            matrix0 [rows, columns] = new Random().Next(1, 10);
        }
    }
    return matrix0;
}
void PrintMatrix (int [,] matrix0)
{
    for (int rows = 0; rows < matrix0.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix0.GetLength(1); columns++)
        {
            Console.Write($"{matrix0 [rows, columns]} ");
        }
        Console.WriteLine();
    }
}
int [,] matrix = new int [3, 4];
PrintMatrix(matrix);
Console.WriteLine();
FillingMatrix(matrix);
PrintMatrix(matrix);
*/
/*
int[,] pic = new int[,]
{
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
 {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};
void PrintImage (int [,] image0)
{
    for (int rows = 0; rows < image0.GetLength(0); rows++)
    {
        for (int columns = 0; columns < image0.GetLength(1); columns++)
        {
            if (image0 [rows, columns] == 0)
            {
              Console.Write("  ");  
            }
            else Console.Write("++");
            //Console.Write($"{image0 [rows, columns]} ");
        }
        Console.WriteLine();
    }
}
PrintImage(pic);
*/
/*
double Factorial (int n)
{
    if (n == 1) return 1;
    else return n * Factorial (n - 1);
}
for (int index = 1; index <40; index++ )
{
    Console.WriteLine($"{index} {Factorial(index)}");
}
*/

double Fibo (int n)
{
    // f(1) = 1
    // f(2) = 1

    if (n == 1) return 1;
    if (n == 2) return 1;
    else return Fibo(n-1)+Fibo(n-2);
}
for (int index = 1; index <50; index++ )
{
    Console.WriteLine($"{index} {Fibo(index)}");
}