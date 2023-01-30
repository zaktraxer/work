using static System.Console;
Clear();

Write("Введите размер матрицы: ");
string[] parameters=ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);

double[,] array=GetMatrixArray(int.Parse(parameters[0]),int.Parse(parameters[1]));
PrintMatrixArray(array);

double[,] GetMatrixArray(int rows, int columns)
{
    double[,] resultArray=new double[rows,columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {   
        resultArray[i,j] =  rand.Next(-10,10) + rand.NextDouble();
        }
    }
return resultArray;
}

void PrintMatrixArray(double[,] inArray)
{
for (int i = 0; i < inArray.GetLength(0); i++)
{
for (int j = 0; j < inArray.GetLength(1); j++)
{
Write($"{Math.Round(inArray[i,j],2),5} ");
}
WriteLine();
}
}