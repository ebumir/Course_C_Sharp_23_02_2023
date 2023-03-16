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
int[] MultiMass(int[] arr)
{
    int size= arr.Length;
    int[] newmass = new int [size/2+size%2];
    for(int i = 0; i<size/2; i++)
    {
        newmass[i] = arr[i]*arr[size-1-i];
       
    }
    if(size%2==1)
    {
        newmass[newmass.Length-1]=arr[arr.Length/2];
    }
    return newmass;
}

Console.WriteLine("enter the length of the array:");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the min value of the array element:");
int y = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the max value of the array element:");
int z = int.Parse(Console.ReadLine()!);

int[] mass= EigthMass(x,y,z);
LengthMass(mass);

int[] result = MultiMass(mass);
LengthMass(result);