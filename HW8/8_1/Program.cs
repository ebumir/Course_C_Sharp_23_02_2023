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

void Permutation (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j <arr.GetLength(1); j++)
        {
            for (int k = 0; k <arr.GetLength(1)-j-1; k++)
            {
             if(arr[i,k]<arr[i,k+1])
                (arr[i,k],arr[i,k+1])=(arr[i,k+1],arr[i,k]);   
            }
        }
        
    }
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
Permutation(mass);
LengthMass(mass);