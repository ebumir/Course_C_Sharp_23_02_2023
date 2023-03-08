void Num( int a)
{
    if ((a>9999 && a<100000)||(a<-9999 && a>-100000))
    {
        int b = a/10000;
        Console.WriteLine(b);
        int c = a%10;
         Console.WriteLine(c);
        int d = a/1000;
        d= d%10;
         Console.WriteLine(d);
        int e = a/10;
        e=e%10;
         Console.WriteLine(e);
        if(b == c && d == e)
        {
            Console.WriteLine("Yes!");
        }
        else
        {
            Console.WriteLine("No!");
        }
    }
    else 
    {
         Console.WriteLine("err");
    }
            
}
Console.WriteLine("Enter a five-digit Number:");
int x = int.Parse(Console.ReadLine()!);
Num(x);