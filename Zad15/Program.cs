using static System.Console;
Clear();
WriteLine("Введите число месяца - ");
int number = Convert.ToInt32(ReadLine());
if (number <= 31)
{
    if (number % 7 == 0 || number % 7 == 6)
    {
        WriteLine("Выходной");
    }
    else
    {
        WriteLine("Не выходной");
    }
}
else
{
    WriteLine("Вы на Земле?");
}