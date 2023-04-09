void SeriesFromTo (int a, int b)
{
    if (a==b-1)
        return;
    SeriesFromTo (a-1,b);
    System.Console.Write($"{a}; ");
   
}

Console.WriteLine("enter first the number:");
int Number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter second the number:");
int Number2= int.Parse(Console.ReadLine()!);
SeriesFromTo(Number1,Number2);