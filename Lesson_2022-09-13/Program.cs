Console.Clear();

string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}

int NumbersStep(int a, int n)
{
    if (n > 0) return a * NumbersStep (a, n-1);
    else return 1;
}

Console.WriteLine(NumbersFor(1, 10));

Console.WriteLine(NumbersRec(1, 10));
Console.WriteLine(NumbersStep(2, 3));