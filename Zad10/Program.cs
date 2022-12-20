using static System.Console;
Clear();
WriteLine("Введите трехзначное число - ");
int number = Convert.ToInt32(ReadLine());

int a = (number - (number / 100) * 100) / 10;

WriteLine(a);