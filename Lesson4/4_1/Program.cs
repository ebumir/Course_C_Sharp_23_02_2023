int SumNum(int num)
{
    int sum = 0;

    for (int i=1; i<=num; i++)
        sum +=i;
    return sum;
}
Console.WriteLine("Enter a Number");
int a = int.Parse(Console.ReadLine()!);
int result = SumNum(a);
Console.WriteLine(result);