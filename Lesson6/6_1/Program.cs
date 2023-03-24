void Triangle(int a, int b, int c)
{
    if ((a < b + c) && (b < a + c) && (c < a + b))
        Console.WriteLine("Yes!");
    else
        Console.WriteLine("No!");
}
Console.WriteLine("enter the length of side A:");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the length of side B:");
int y = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the length of side C:");
int z = int.Parse(Console.ReadLine()!);
Triangle(x, y, z);