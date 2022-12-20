using static System.Console;
Clear();
WriteLine("Введите число - ");
int number1 = Convert.ToInt32(ReadLine());
int n = 0;
while (n <= number1)
{
    WriteLine(n);
    n = n + 2;
}