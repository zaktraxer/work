using static System.Console;
Clear();
WriteLine("Введите колчество членов массива");
int count = int.Parse(ReadLine()!);
WriteLine("Введите минимальный член массива");
int armin = int.Parse(ReadLine()!);
WriteLine("Введите максимальный член массива");
int armax = int.Parse(ReadLine()!);
int [] array = GetArray(count,armin,armax);
Printarray(array);
int summa = SumOdd(array);
WriteLine($"Сумма элементов на нечетных местах равна {summa}");

int[] GetArray(int num, int min, int max)
{
    int[] res = new int[num];
    Random rand = new Random();
    for (int i=0; i<num; i++)
    {
        res[i] = rand.Next(min,max);
    }
    return res;
}

void Printarray(int[] array)
{
    int count=array.Length;
    for (int i=0; i<count; i++)
    {
        Write($"{array[i]} ");
    }
    WriteLine("");
}

int SumOdd(int[] array)
{
    int count=array.Length;
    int sum=0;
    for (int i=1; i<count; i++)
    {
        if (i%2==1)
        {
            sum=sum+array[i];
        }
    } 
    return sum;
}
