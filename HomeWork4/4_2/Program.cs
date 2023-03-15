int SumNum(int num)
{
    int a = 0;
    if (num>0)
    {
        for (int i = 0; num>0; i++)
        {
            int b = num%10;
            a+=b;
            num/=10;
        }
    }
    else
    {
        for (int i = 0; num<0; i--)
        {
            int b = num%10;
            a+=b;
            num/=10;
        }
    }
    return a;
}
Console.WriteLine("Enter a number:");
int x = int.Parse(Console.ReadLine()!);
int result = SumNum(x);
Console.WriteLine(result);
