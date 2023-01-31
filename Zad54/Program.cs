using static System.Console;
Clear();

Write("Введите размер матрицы: ");
string[] parameters=ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);

int[,] array=GetMatrixArray(int.Parse(parameters[0]),int.Parse(parameters[1]));
PrintMatrixArray(array);
SortLineMatrix(array);
WriteLine("");
PrintMatrixArray(array);

void SortLineMatrix(int[,] array)
{
    for (int j=0; j<array.GetLength(0); j++)
    {
        for (int i=1; i<array.GetLength(1)-1; i++)
        {
            for (int k=0; k<array.GetLength(1)-i; k++)
            {
                if (array[j,k]<array[j,k+1])
                {
                    int temp = array[j,k];
                    array[j,k] = array[j,k+1];
                    array[j,k+1] = temp;
                }
            }
        }
    }    
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