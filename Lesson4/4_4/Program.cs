void Massive( int mas)
{
    int[] num = new int [mas];
    for(int i = 0; i<mas; i++)
    {
        num[i] = new Random().Next(2);
        Console.Write($"{num[i]} ");
    }
}

Massive(8);