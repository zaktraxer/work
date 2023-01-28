using static System.Console;
Clear();
WriteLine("Введите колчество членов массива");
int count = int.Parse(ReadLine()!);

int [] array = GetArray(count);
Printarray(array);
int sum = Checkeven(array);
WriteLine($"В данном массиве {sum} четных элементов");

int[] GetArray(int num)
{
    int[] res = new int[num];
    Random rand = new Random();
    for (int i=0; i<num; i++)
    {
        res[i] = rand.Next(100,1000);
    }
    return res;
}

int Checkeven(int[] array)
{
    int total =0;
    for (int i=0;i<array.Length; i++)
    {
        if (array[i]%2==0)
        {
            total++;
        }
    }
    return total;
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
