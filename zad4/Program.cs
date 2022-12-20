using static System.Console;
Clear();
WriteLine("Введите число 1 - ");
int number1 = Convert.ToInt32(ReadLine());
WriteLine("Введите число 2 - ");
int number2 = Convert.ToInt32(ReadLine());
WriteLine("Введите число 3 - ");
int number3 = Convert.ToInt32(ReadLine());
if (number1 > number2 && number1 > number3)
{
    Console.WriteLine($"Максимальное число {number1}");
}
if (number2 > number1 && number2 > number3)
{
    Console.WriteLine($"Максимальное число {number2}");
}
if (number3 > number1 && number3 > number2)
{
    WriteLine($"Максимальное число {number3}");
}