void ResNums (int num )
{
    if (num==0)
        return;
    ResNums (num -1);
    System.Console.Write($"{num}; ");
}

Console.WriteLine("enter the number:");
int Number = int.Parse(Console.ReadLine()!);
ResNums (Number);