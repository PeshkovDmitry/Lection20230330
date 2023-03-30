﻿string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}
string NumbersRec(int a, int b)
{
    if (a >= b) return $"{a} " + NumbersRec(a - 1, b);
    else return String.Empty;
}
Console.WriteLine(NumbersFor(10, 1)); // 10 9 8 7 6 5 4 3 2 1
Console.WriteLine(NumbersRec(10, 1)); // 10 9 8 7 6 5 4 3 2 1