// **Задача 65:** Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

using static System.Console;
Clear();
WriteLine(GetNumbers1(2,10));
WriteLine();
PrintNumbers(1,9);


string GetNumbers1(int n, int m)
{
    return (m == n) ? m.ToString() : $"{GetNumbers1(n,m-1)},{m}";
}


void PrintNumbers(int n, int m)
{
    if (m == n) Write(m);
    else
    {
        PrintNumbers(n,m-1);
        Write($",{m}");
    }
}