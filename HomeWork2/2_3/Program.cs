int TakeNum(int num)
{
    if (num>=0)
    {
        if (num>=100)
        {
            while (num>999)
            
            num = num /10;
            
        }
        else 
        {
        Console.WriteLine("Третьей цифры нет!");
        }
    }
    else
    {
        if (num<=-100)
        {
            while (num<-999)
            num = num/10;
        }
        else 
        {
        Console.WriteLine("Третьей цифры нет!");
        }
    }
    
    int num1= num % 10;
    return num1;
}
Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine()!);
int result = TakeNum(a);
Console.WriteLine(result);