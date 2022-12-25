using static System.Console;
Clear();
WriteLine("Введите пятизначное число - ");
int number = Convert.ToInt32(ReadLine());
if (number / 10000 >= 1 && number / 10000 <= 9)
{
    int n1 = number / 10000;
    int n2 = (number / 1000) % 10;
    int n4 = (number % 100) / 10;
    int n5 = number % 10;

    if (n1 == n5 && n2 == n4)
    {
        Console.WriteLine($"Число {number} палиндром");
    }
    else
    {
        Console.WriteLine($"Число {number} не палиндром");
    }
}
else
{
    Console.WriteLine($"Число {number} не пятизначное");
}