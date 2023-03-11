void LengthMass(int massivelength, int min, int max)
{
     int[] num = new int [massivelength];
    for(int i = 0; i<massivelength; i++)
    {
        num[i] = new Random().Next(min,max);
        Console.Write($"{num[i]} ");
    }
}
Console.WriteLine("enter the length of the array:");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the min value of the array element:");
int y = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the max value of the array element:");
int z = int.Parse(Console.ReadLine()!);

LengthMass(x,y,z);



