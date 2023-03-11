double Power(int num, int degree)
{
    int degnum = num;
    if (degree<=0)
        Console.WriteLine("Err");
    else
    {
    for (int i = 1; i < degree; i++)
    {
        degnum*=num;
    }
    }
    return degnum;
}
Console.WriteLine("enter a number:");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter a degree-number:");
int y = int.Parse(Console.ReadLine()!);
double result = Power(x,y);
Console.WriteLine(result);