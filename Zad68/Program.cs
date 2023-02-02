using static System.Console;
Clear();
WriteLine("Введите число N");
int N = int.Parse(ReadLine()!);
WriteLine("Введите число M");
int M = int.Parse(ReadLine()!);
int eee = Akk(N, M);
WriteLine(eee);

static int Akk(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Akk(n - 1, 1);
    else
        return Akk(n - 1, Akk(n, m - 1));
}