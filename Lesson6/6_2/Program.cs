string ConvertBin(int a)
{
    string result = "";
    while (a > 0)
    {
        result = a % 2 + result;
        a /= 2;
    }
    return result;
}

Console.WriteLine("enter a number:");
int x = int.Parse(Console.ReadLine()!);
string bin = ConvertBin(x);
Console.WriteLine(bin);