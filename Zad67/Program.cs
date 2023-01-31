int result = GetNumbersSum(123456789);
Console.WriteLine(result);
// 123
int GetNumbersSum(int num)
{
    if (num / 10 == 0) return num%10;
    
    else return GetNumbersSum(num/10) + num%10;

}