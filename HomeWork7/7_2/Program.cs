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

void FindNum(int[,] arr)
{
    int row = arr.GetLength(0);
    int columns = arr.GetLength(1);
    System.Console.WriteLine("enter a row index:");
    int rowindex = int.Parse(Console.ReadLine()!);
    while (rowindex>row)
    {
        System.Console.WriteLine("invalid index! enter a row index: ");
        rowindex = int.Parse(Console.ReadLine()!);
    }
    System.Console.WriteLine("enter a columns index:");
    int colindex = int.Parse(Console.ReadLine()!);
    while (colindex>columns)
    {
        System.Console.WriteLine("invalid index! enter a columns index: ");
        colindex=int.Parse(Console.ReadLine()!);
    }       
    for (int i=0; i< row; i++)
        for (int j = 0; j < columns; j++)
            if(i==rowindex & j == colindex)
                System.Console.WriteLine($"number found:{arr[i,j]}");
            
        


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
FindNum(mass);