using static System.Console;
Clear();

Write("Введите размер матрицы: ");
string[] parameters=ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);

int[,] array=GetMatrixArray(int.Parse(parameters[0]),int.Parse(parameters[1]));
PrintMatrixArray(array);
checkPos(array);

void checkPos(int[,] matrix)
{
    Write("Введите позицию элемента: ");
    string[] position=ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);
    int a=int.Parse(position[0]);
    int b=int.Parse(position[1]);
    if (a<=matrix.GetLength(0) && b<=matrix.GetLength(1))
    {
        WriteLine($"Лежит в матрице и равен {matrix[a,b]}");
    }
    else {WriteLine("Элемент не в матрице");}
}


int[,] GetMatrixArray(int rows, int columns)
{
    int[,] resultArray=new int[rows,columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i,j] = rand.Next(10);
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