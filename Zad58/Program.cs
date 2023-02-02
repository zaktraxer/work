using static System.Console;
Clear();

Write("Введите размер первой матрицы: ");
string[] parameters=ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);
int[,] array=GetMatrixArray(int.Parse(parameters[0]),int.Parse(parameters[1]));
Write("Введите размер второй матрицы: ");
string[] parameters2=ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);
int[,] array2=GetMatrixArray(int.Parse(parameters2[0]),int.Parse(parameters2[1]));
int[,] result=CompositionMatrix(array,array2);
PrintMatrixArray(array);
WriteLine("");
PrintMatrixArray(array2);
WriteLine("");
PrintMatrixArray(result);
int[,] CompositionMatrix(int[,] inarray1, int[,] inarray2)
{
    if (inarray1.GetLength(1) != inarray2.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
    int[,] result= new int[inarray1.GetLength(0),inarray2.GetLength(1)];
    for (int i = 0; i < inarray1.GetLength(0); i++)
    {
        for (int j=0; j < inarray2.GetLength(1); j++)
        { 
            for(int k=0; k< inarray2.GetLength(0); k++)
            {
                result[i,j] += inarray1[i,k]*inarray2[k,j];
            }
        }        
    }
    return result;
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

int[,] GetMatrixArray(int rows, int columns)
{
    int[,] resultArray=new int[rows,columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i,j] = rand.Next(5);
        }
    }
    return resultArray;
}