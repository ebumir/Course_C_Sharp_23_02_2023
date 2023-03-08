double Distance(double x1, double y1, double z1 ,double x2, double y2 , double z2)
{
    double a = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
    double b = Math.Round(a,3);
    return b;
}

Console.WriteLine(Distance(3,6,2,1,3,7));
