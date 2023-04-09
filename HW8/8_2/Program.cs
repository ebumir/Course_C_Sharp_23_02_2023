void LengthMass(int[,] arr)
{
    Console.WriteLine();
    for (int i=0; i< arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i,j]} ");
    Console.WriteLine();
    }
}


int[,] EigthMass(int row, int columns, int from, int to)
{
  int[,] arr = new int [row,columns];
    for(int i = 0; i<row; i++)
    {
        for(int j =0; j<columns; j++)
            arr[i,j] = new Random().Next(from,to+1);
       
    }
    return arr;
}

int[] SumNumsRow (int[,] arr)
{
    int[] sum = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
           sum[i]+=arr[i,j];
    return sum;
}
int MinSum(int[] sum)
{
    System.Console.WriteLine();
    int min = 0;
    for (int i = 1; i < sum.Length; i++)
        if (sum[i]<sum[min])
            min = i;
    return min;
}


Console.WriteLine("enter the number of rows:");
int  RowQuantity= int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the number of columns:");
int  ColumnsQuantity= int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the min value of the array element:");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the max value of the array element:");
int max = int.Parse(Console.ReadLine()!);

int[,] mass= EigthMass(RowQuantity, ColumnsQuantity, min, max);
LengthMass(mass);
int[] newmassive = SumNumsRow(mass);
int res = MinSum(newmassive);
System.Console.WriteLine($"Min sums of element in {res+1} string");
