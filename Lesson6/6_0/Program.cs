void LengthMass(int[] arr)
{
    Console.WriteLine();
    for (int i=0; i< arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] EigthMass(int size, int from, int to)
{
  int[] arr = new int [size];
    for(int i = 0; i<size; i++)
    {
        arr[i] = new Random().Next(from,to);
       
    }
    return arr;
}

void Deploy(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i<size/2; i++)
    {
        (arr[i], arr[size -1 -i])= (arr[size - 1 - i], arr [i]);
    }
}

Console.WriteLine("enter the length of the array:");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the min value of the array element:");
int y = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the max value of the array element:");
int z = int.Parse(Console.ReadLine()!);

int[] mass= EigthMass(x,y,z);
LengthMass(mass);
Deploy (mass);
LengthMass(mass);