using static System.Console;
Clear();

Write("Введите размер матрицы: ");
string[] parameters=ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);
int[,] array=GetMatrixArray(int.Parse(parameters[0]),int.Parse(parameters[1]));
PrintMatrixArray(array);
double[] Sredn=SrednStolbca(array);
Printarray(Sredn);

double[] SrednStolbca(int[,] Matrix)
{
    double[] array = new double[Matrix.GetLength(1)];
    for (int i=0; i<Matrix.GetLength(1); i++)
    {   
        double sum=0;
        for(int j=0; j<Matrix.GetLength(0); j++)
        {
            sum = sum + Matrix[j,i];
        }
        array[i]=  sum / Matrix.GetLength(0);
    }
    return array;
}

void Printarray(double[] array)
{
    int count=array.Length;
    for (int i=0; i<count; i++)
    {   
        Write($"{Math.Round(array[i], 2),5} ");
    }
    WriteLine("");
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
            resultArray[i,j] = rand.Next(10);
        }
    }
    return resultArray;
}