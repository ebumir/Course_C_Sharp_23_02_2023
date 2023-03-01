Console.WriteLine("Здравствуйте Мария!");
Console.WriteLine("Введите число!");
int a = int.Parse(Console.ReadLine()!);
int b = -a;
if ((a % 2)==0)
{
    while (b<=a-4)
    {
        Console.Write($"{b+2}, ");
        b = b+2;
    }
}
else 
{
    b= -a-1;
    while (b<=a-2)
    {
       
        Console.Write($"{b+2}, ");
        b = b+2;
    }
}
Console.WriteLine("");
Console.WriteLine("Мария, Я очень вам благодарен, с вами приятно Работать!");