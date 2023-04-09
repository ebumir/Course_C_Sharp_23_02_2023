int SumDigit (int num)
{
    if (num == 0) return 0;
    
    return SumDigit (num / 10) + num % 10;
}

Console.WriteLine("enter the number:");
int Number = int.Parse(Console.ReadLine()!);
int res = SumDigit(Number);
System.Console.WriteLine(res);