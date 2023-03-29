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
string LengthDoubMass(double[] arr)
{
     string res = string.Empty;
    for (int i = 0; i < arr.Length; i++)
       {
        res += Math.Round(arr[i],2)+" ";
       }
    return res;
}

double[] ArithmeticMean(int[,] arr)
{
     
    int row = arr.GetLength(0);
    int columns = arr.GetLength(1);
    double[] midmass = new double[columns];
    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < row; j++)
            midmass[i] += arr[j,i];
        midmass[i] /= arr.GetLength(0);
    }



    return midmass;

                 
    
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

double[] result = ArithmeticMean(mass);
string res = LengthDoubMass(result);
System.Console.WriteLine(res);