int PowNums(int a, int b)
{
    if (b == 0) return 1;
    return a * PowNums(a, b - 1);

}
Console.WriteLine("enter first the number:");
int Number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter second the number:");
int Number2 = int.Parse(Console.ReadLine()!);

int res = PowNums(Number1, Number2);
System.Console.WriteLine(res);