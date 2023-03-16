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

int SumEven(int[] arr)
{
    int evensum =0;
    for(int i = 1; i<arr.Length; i+=2)
    {
        evensum+=arr[i];
    }
    return evensum;
}

Console.WriteLine("enter the length of the array:");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the min value of the array element:");
int y = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the max value of the array element:");
int z = int.Parse(Console.ReadLine()!);


int[] mass = EigthMass(x, y, z);
LengthMass(mass);
int result = SumEven(mass);
Console.WriteLine(result);