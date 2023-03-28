void LengthMass(double[,] arr)
{
    Console.WriteLine();
    for (int i=0; i< arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i,j]} ");
    Console.WriteLine();
    }
}


double [,] EigthMass(int row, int columns, int from, int to)
{
    Random rand = new Random();
    double [,] arr = new double [row,columns];
    for(int i = 0; i<row; i++)
    {
        for(int j =0; j<columns; j++)
            arr[i,j] = Math.Round(rand.NextDouble()*to+1-from, 2);
       
    }
    return arr;
}

Console.WriteLine("enter the number of rows:");
int  RowQuantity= int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the number of columns:");
int  ColumnsQuantity= int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the min value of the array element:");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the max value of the array element:");
int max = int.Parse(Console.ReadLine()!);

double [,] mass= EigthMass(RowQuantity, ColumnsQuantity, min, max);
LengthMass(mass);