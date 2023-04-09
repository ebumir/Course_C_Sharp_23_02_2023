void LengthMass(int[,] arr)
{
    int row = arr.GetLength(0);
    int columns = arr.GetLength(1);
    Console.WriteLine();
    for (int i=0; i< row; i++)
    {
        for (int j = 0; j < columns; j++)
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

void Repositnon(int[,]arr)
{
    int row = arr.GetLength(0);
    int columns = arr.GetLength(1);
    if (row==columns)
        for (int i = 0; i < row; i++)
            for (int j = 0 ; j <i; j++)
                (arr[i,j], arr[j,i])=(arr[j,i], arr[i,j]);
                    
    else
        System.Console.WriteLine("err");
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
Repositnon(mass);
LengthMass(mass);