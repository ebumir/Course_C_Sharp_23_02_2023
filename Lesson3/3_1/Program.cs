void Qwartes( int x, int y)
{
    if (x== 0 || y ==0)
        Console.WriteLine("Ошибка X или Y равны 0");
    else if (x > 0 && y > 0)
        Console.WriteLine("I");
    else if (x < 0 && y > 0)
        Console.WriteLine("II");
    else if (x < 0 && y < 0)
        Console.WriteLine("III");
    else if (x > 0 && y < 0)
        Console.WriteLine("IV");
}
Console.WriteLine("Введите Х:");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Y:");
int b = int.Parse(Console.ReadLine()!);
Qwartes(a,b);