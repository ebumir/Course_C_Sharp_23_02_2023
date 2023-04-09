void LengthMass(int[,] arr)
{
    Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
}


int[,] EigthMass(int row, int columns, int from, int to)
{
    int[,] arr = new int[row, columns];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < columns; j++)
            arr[i, j] = new Random().Next(from, to + 1);

    }
    return arr;
}
int[] MinElementFind(int[,] arr)
{
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            if (arr[i, j] < arr[minI, minJ])
            {
                minI = i;
                minJ = j;
            }
    return new int[] { minI, minJ };
}

int[,] DeleteElWithRowCol(int[,] arr, int[] pos)
{
    int row = pos[0];
    int col = pos[1];
    int[,] newarr = new int [arr.GetLength(0)-1, arr.GetLength(1)-1];
    for (int i = 0, a = 0; i < arr.GetLength(0); i++, a++)
    {
        if (i!=row)
        {
            for (int j = 0, b = 0; j < arr.GetLength(1); j++, b++)
            {
                if(j!=col)
                    newarr[a,b] = arr[i,j];
                else
                    b--;
            }
        }
        else
            a--;
    }
    return newarr;


}

Console.WriteLine("enter the number of rows:");
int RowQuantity = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the number of columns:");
int ColumnsQuantity = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the min value of the array element:");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the max value of the array element:");
int max = int.Parse(Console.ReadLine()!);

int[,] mass = EigthMass(RowQuantity, ColumnsQuantity, min, max);
LengthMass(mass);
int[] min_el_index = MinElementFind(mass);
int[,] resmass = DeleteElWithRowCol(mass,min_el_index);
LengthMass(resmass);