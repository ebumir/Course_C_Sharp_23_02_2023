void Div(int a, int b)
{
    if (a % b == 0)
        Console.WriteLine("Кратно!");
    else
        Console.WriteLine("Некратно! Остаток: " + (a % b));
}
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine()!);

Div(a,b);