
int TakeNum(int num)
{
    Console.WriteLine(num);
    int num1 = num / 10;
    int num2 = num1 % 10;
    return num2;

}
int result = TakeNum(new Random().Next(100,1000));
Console.WriteLine($"Второе число: {result}");
