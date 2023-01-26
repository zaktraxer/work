using static System.Console;
Clear();
WriteLine("Введите первое число");
int number1 = int.Parse(ReadLine()!);
WriteLine("Введите второе число");
int number2 = int.Parse(ReadLine()!);
int pow1=GetPow(number1, number2);
WriteLine($"{number1} В степени {number2} равно {pow1}");
int GetPow (int A, int B)
{
    int result=1;
    while  (B>0)
    {
        result *= A;
        B--;
    }
    return result;
}