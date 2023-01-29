using static System.Console;
Clear();

int[] array = GetArray();
Printarray(array);
int count = Checkpositive(array);
WriteLine($"Количество четных элементов {count}");
int[] GetArray()
{
    Write("Введите члены массива через пробел ");
    string[] stroka = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] array = new int[stroka.Length];
    for (int i=0; i<stroka.Length; i++)
    {
        array[i]=int.Parse(stroka[i]);
    }
    return array;
}

int Checkpositive(int[] array)
{
    int count = 0;
    foreach (int a in array)
    {
        count+= a>0? 1:0;
    }
    return count;
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