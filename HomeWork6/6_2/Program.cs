void Intersection(double k1,double b1,double k2,double b2)
{ 
    double k = k1 - k2;
    if ( k != 0)
    {
        double x = (b2-b1)/(k1-k2);
        double y = k1*x+b1;
        Console.WriteLine($"{x};{y}");
    }
    else if (k1==k2&&b1==b2)
        Console.WriteLine("imposition");
    else
        Console.WriteLine("paralell");
}



Console.WriteLine("enter a value for A1:");
double  a1= double.Parse(Console.ReadLine()!);
Console.WriteLine("enter a value for B1:");
double  b1= double.Parse(Console.ReadLine()!);
Console.WriteLine("enter a value for A2:");
double a2 =double.Parse(Console.ReadLine()!);
Console.WriteLine("enter a value for B2:");
double b2 = double.Parse(Console.ReadLine()!);
Intersection(a1,b1,a2,b2);