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

int[,] MatrixMult(int[,]arr1, int[,]arr2)
{
    int row1 = arr1.GetLength(0);
    int col1=arr1.GetLength(1);
    int row2 = arr2.GetLength(0);
    int col2=arr2.GetLength(1);

    int[,] multimatrix = new int[row1,col1];
    if (row1 != col2) return multimatrix;
    else if (row1==col2)
        multimatrix = new int[row1,col2];
    
    for (int i = 0; i < row1; i++)
         for (int j = 0; j < col2 ; j++)
            for (int k = 0; k < col1; k++)
                multimatrix[i,j]+= arr1[i,k]*arr2[k,j];
    return multimatrix;

}


Console.WriteLine("enter the number of rows:");
int  RowQuantity= int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the number of columns:");
int  ColumnsQuantity= int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the min value of the array element:");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the max value of the array element:");
int max = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the number of rows:");
int  RowQuantity2= int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the number of columns:");
int  ColumnsQuantity2= int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the min value of the array element:");
int min2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the max value of the array element:");
int max2 = int.Parse(Console.ReadLine()!);

int[,] mass1= EigthMass(RowQuantity, ColumnsQuantity, min, max);
LengthMass(mass1);


int[,] mass2= EigthMass(RowQuantity2, ColumnsQuantity2, min2, max2);
LengthMass(mass2);

int[,] newmass = MatrixMult(mass1, mass2);
LengthMass(newmass);

