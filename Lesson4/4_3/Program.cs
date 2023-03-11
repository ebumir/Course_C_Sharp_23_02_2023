int Multiply(int num)
{
    int a = 1;
    for (int i = 1; i <= num; i++)
    a*=i;
    return a;
}
Console.WriteLine("enter a number:");
int x = int.Parse(Console.ReadLine()!);
int result = Multiply(x);
Console.WriteLine(result);