int PositiveNumber( int Num)
{
    int count =0;
    for (int i = 0; i < Num; i++)
    {
        Console.WriteLine("Enter a number:");
        int nums = int.Parse(Console.ReadLine()!);
        if (nums > 0)
            count+=1;
    }
    return count;
}
Console.WriteLine("Enter a number of digits:");
int numbers = int.Parse(Console.ReadLine()!);
int posNum = PositiveNumber(numbers);
Console.WriteLine(posNum);
