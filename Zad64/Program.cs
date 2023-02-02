using static System.Console;
Clear();
WriteLine("Введите число");
int N = int.Parse(ReadLine()!);
WriteLine(GetNumbers1(N));

string GetNumbers1(int m)
{
    return (m == 1) ? m.ToString() : $"{m},{GetNumbers1(m-1)}";
}
