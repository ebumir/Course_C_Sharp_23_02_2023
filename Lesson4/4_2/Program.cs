int LengthNum( int num)
{
    int a = 0;
    for(int i = 1; num>0 ; i++)
    {
        num/=10;
        a++;
        
    }
    return a;
}

Console.WriteLine("Enter a Number");
int x = int.Parse(Console.ReadLine()!);
int length = LengthNum(x);
Console.WriteLine(length);