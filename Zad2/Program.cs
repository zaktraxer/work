using static System.Console;
Clear();
WriteLine("Введите число 1 - ");
int number1 = Convert.ToInt32(ReadLine());
WriteLine("Введите число 2 - ");
int number2 = Convert.ToInt32(ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"Большее {number1} Меньшее {number2} ");
}
else
{
    Console.WriteLine($"Большее {number2} Меньшее {number1} ");
}