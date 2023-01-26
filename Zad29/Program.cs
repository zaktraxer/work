using static System.Console;
using System;
Clear();
int [] array = GetArray();
Printarray(array);

int[] GetArray()
{
    int[] res = new int[8];
    Random rand = new Random();
    for (int i=0; i<8; i++)
    {
        res[i] = rand.Next(100);
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
}
