using static System.Console;
Clear();
WriteLine("Введите количество членов массива");
int count = int.Parse(ReadLine()!);
WriteLine("Введите минимальный член массива");
double armin = double.Parse(ReadLine()!);
WriteLine("Введите максимальный член массива");
double armax = double.Parse(ReadLine()!);
double [] array = GetArray(count,armin,armax);
Printarray(array);
Razn(array);

double[] GetArray(int num, double min, double max)
{
    double[] res = new double[num];
    Random rand = new Random();
    for (int i=0; i<num; i++)
    {   
        res[i] = min + rand.NextDouble() * (max - min);
    }
    return res;
}

void Printarray(double[] array)
{
    int count=array.Length;
    for (int i=0; i<count; i++)
    {   
        Write($"{Math.Round(array[i], 2)} ");
    }
    WriteLine("");
}
void Razn(double[] array)
{
    double raznost = 0;
    int count = array.Length;
    double minimum = array[0];
    double maximum = array[0];
    for (int i=0; i<count ; i++)
    {
        if (array[i]>maximum) 
        {
            maximum = array[i];
        }
        else
        {
            if (array[i]<minimum)
            {
                minimum = array[i];
            }
        }
    }
    raznost = maximum - minimum;
    Write($"Разница максимального {Math.Round(maximum, 2)} и минимального {Math.Round(minimum, 2)} элемента равна {Math.Round(raznost, 2)}");
}