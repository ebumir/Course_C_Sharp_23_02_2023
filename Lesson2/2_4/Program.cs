void Div(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
        Console.WriteLine("Кратно!");
    else
        Console.WriteLine("Не кратно!");
}
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine()!);

Div(a);