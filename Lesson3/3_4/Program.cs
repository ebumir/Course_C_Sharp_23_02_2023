void Div( int num)
{
    int i = 1;
    if (num > 0)
    {
        while (i<=num)
        {
            Console.Write($"{Math.Pow(i,2)}  ");
            i++;
        }
    }
    else if (num<0)
    {
        while (i>=num)
        {
            Console.Write($"{Math.Pow(i,2)}  ");
            i--;
        }
    }
    else 
        Console.WriteLine("Err");
}
Console.WriteLine("Enter a Number");
int a = int.Parse(Console.ReadLine()!);
Div(a);

