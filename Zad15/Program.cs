using static System.Console;
Clear();
WriteLine("Введите число месяца - ");
int number = Convert.ToInt32(ReadLine());
if (number <= 31)
{
    if (number == 6 || number == 7 || number == 13 || number == 14 || number == 20 || number == 21 || number == 27 || number == 28)
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