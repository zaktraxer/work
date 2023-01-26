using static System.Console;
Clear();
WriteLine("Введите число");
int number = int.Parse(ReadLine()!);
int sum = GetSumDigit(number);
WriteLine($"Сумма цифр числа {number} равна {sum}");

int GetSumDigit (int num)
{
    int result=0;
    int digitcount = (int)Math.Log10(num)+1;
    while (digitcount > 0)
    {
        int a = num % 10;
        num = num / 10;
        result=result+a;
        digitcount --;
    }
    return result;
}