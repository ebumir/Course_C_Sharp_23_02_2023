void LengthMass(int[] arr)
{
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] EigthMass(int size, int from, int to)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to);

    }
    return arr;
}

int Diaposon(int[] arr)
{
    int f = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99)
            f++;
    
    }
    Console.WriteLine();
    return f;

}

Console.WriteLine("enter the length of the array:");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the min value of the array element:");
int y = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the max value of the array element:");
int z = int.Parse(Console.ReadLine()!);

int[] mass = EigthMass(x, y, z);
LengthMass(mass);

int aboardnum = Diaposon(mass);
Console.WriteLine(aboardnum);
