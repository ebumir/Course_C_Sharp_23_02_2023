void Num (int num)
{
    int i =1;
    if (num>0)
    {
        while (i<=num)
        {
            Console.Write($"{Math.Pow(i,3)} ");
            i++;
        }
    }
    else if (num<0)
    {
        while (num<=i)
        {
            Console.Write($"{Math.Pow(num,3)} ");
            num++;
        }
    }
    else 
    {
        Console.Write("0 1");
    }
}
Console.WriteLine("Enter a Number:");
int a = int.Parse(Console.ReadLine()!);
Num(a);
