using static System.Console;
Clear();
Write("Введите коэффициенты k1, b1, k2, b2 через пробел ");
string[] stroka = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
double[] array = {int.Parse(stroka[0]), int.Parse(stroka[1]), int.Parse(stroka[2]), int.Parse(stroka[3])};
Printarray(array);
double[] Koord = Tochka(array);
Printarray(Koord);

double[] Tochka(double[] array)
{
    double[] koord= new double[2];
    koord[0]=((array[3]-array[1])/(array[0]-array[2]));
    koord[1]=array[0]*koord[0] + array[1];
    return koord;
}
void Printarray(double[] array)
{
    int count=array.Length;
    for (int i=0; i<count; i++)
    {
        Write($"{array[i]} ");
    }
    WriteLine("");
}

// int AskUserForNumber(string inPrompt)
// {
//     int resultNum = 0;
//     string UserInput = "";
//     while (!int.TryParse(UserInput, out resultNum))
//     {
//         Console.Write(inPrompt);
//         UserInput = Console.ReadLine()!;
//     }
//     return resultNum;
//  }