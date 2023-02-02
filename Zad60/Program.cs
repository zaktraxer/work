using static System.Console;
Clear();

int[,,] result = GetMatrixArray();
PrintMatrixArray(result);


int[,,] GetMatrixArray()
{
    int[,,] resultArray=new int[2,2,2];
    var array=Enumerable.Range(10,90).ToArray();
    Random rand = new Random();
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for(int k = 0; k < 2; k++)
            {
            resultArray[i,j,k] = array[new Random().Next(0,array.Length)];
            array = array.Where(e => e != resultArray[i,j,k]).ToArray();
            }
        }
    }

    return resultArray;
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
void PrintMatrixArray(int[,,] inArray)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for(int k=0 ; k<2; k++)
            Write($"{inArray[i,j,k],5}({i},{j},{k}) ");
        }
    WriteLine();
    }
}