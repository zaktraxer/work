int result = GetPower(3,5);
Console.WriteLine(result);

int GetPower(int a, int b)
{
    if (b == 1) return a;

    else return GetPower(a, b-1)*a;

}