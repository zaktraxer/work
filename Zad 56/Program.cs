using static System.Console;
Clear();

Write("Введите размер матрицы: ");
string[] parameters=ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);

int[,] array=GetMatrixArray(int.Parse(parameters[0]),int.Parse(parameters[1]));
PrintMatrixArray(array);
NumberMinSum(array);

void NumberMinSum(int[,] array)
{
    int[] Sum = new int[array.GetLength(0)];
    for (int i=0; i<array.GetLength(0); i++)
    {   int k=0;
        for(int j=0; j<array.GetLength(1); j++)
        {
             k += array[i,j];
        }
        Sum[i]=k;
    }
    int index=0;
    int min=Sum[0];
    for (int i=0; i<Sum.Length; i++)
    {   
        if (min>Sum[i])
        {
            min=Sum[i];
            index=i;
        }
    }
    WriteLine($"Строка с минимальной суммой элементов {min} под номером {index+1}");
}

int[,] GetMatrixArray(int rows, int columns)
{
    int[,] resultArray=new int[rows,columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i,j] = rand.Next(15);
        }
    }
    return resultArray;
}

void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j],5} ");
        }
    WriteLine();
    }
}