using static System.Console;
Clear();
WriteLine("Введите число N");
int N = int.Parse(ReadLine()!);
WriteLine("Введите число M");
int M = int.Parse(ReadLine()!);
int Sum= GetNumbersSum(N,M);
WriteLine($"Сумма чисел от M До N равна {Sum}");

int GetNumbersSum(int n, int m)
{
    if (n==m) return n;
    
    else return GetNumbersSum(n, m-1) + m;

}