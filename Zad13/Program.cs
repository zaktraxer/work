using static System.Console;
Clear();
WriteLine("Введите число - ");
int number = Convert.ToInt32(ReadLine());
if ((number / 100) > 0)
{
    number = (number % 1000) / 100;
    WriteLine(number);
}
else
{
    WriteLine("Третьей цифры нет");
}
// WriteLine(number % 10 == 0 ? "");