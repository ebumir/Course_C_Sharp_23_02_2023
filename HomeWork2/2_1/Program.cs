
Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine()!);
int TakeNum(int num)
{
            int num1 = num / 10;
            int num2 = num1 % 10;
        
    return num2;

}
if (a>0 && a>99 && a < 1000)
{
    int result=TakeNum(a);
    Console.WriteLine($"Второе число: {result}");
}
else if (a<0 && a<-99 && a > -1000)
{
    int result=TakeNum(a);
    Console.WriteLine($"Второе число: {result}");
}
else
{
    Console.WriteLine("Число не является трехзначным");
}