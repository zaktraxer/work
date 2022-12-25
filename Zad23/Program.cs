using static System.Console;
Clear();
WriteLine("Введите - ");
int number = Convert.ToInt32(ReadLine());
int i = 1;
while (i <= number)
{
    Write(Math.Pow(i, 3));
    Write(" ");
    i++;
}