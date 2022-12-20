using static System.Console;
Clear();
WriteLine("Введите число - ");
int number1 = Convert.ToInt32(ReadLine());
WriteLine(number1 % 2 == 0 ? "Четное" : "Нечетное");
