void LengthMass(double[] arr)
{
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

double[] EigthMass(int size, int from, int to)
{
    Random rand = new Random();
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(rand.NextDouble()*to-from, 2);

    }
    return arr;
}

void MinMaxDiv(double[] arr)
{
    double min=0;
    double max=1;
    for (int j = 0; j < arr.Length; j++)
    {
        if(arr[j]<min)
        {
            min=arr[j];
        }
        if(arr[j]>max)
        {
            max = arr[j];
        }
    }
    Console.WriteLine($"{max} - {min} = {Math.Round(max-min,2)}");
}

Console.WriteLine("enter the length of the array:");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the min value of the array element:");
int y = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the max value of the array element:");
int z = int.Parse(Console.ReadLine()!);


double[] mass = EigthMass(x, y, z);
LengthMass(mass);
MinMaxDiv(mass);
