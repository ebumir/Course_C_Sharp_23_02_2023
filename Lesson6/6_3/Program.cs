void Fib(int a)
{
    int First = 0;
    int Second= 1;
    for (int i = 0; i<a;i++)
    {
      Console.Write(First + " ");
      (First, Second) = (Second, First+Second); 
    }
}

Console.WriteLine("enter a number:");
int x = int.Parse(Console.ReadLine()!);
Fib(x);
