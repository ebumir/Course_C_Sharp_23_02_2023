Console.WriteLine("Введите число:");
int a = int.Parse( Console.ReadLine()! );
Console.WriteLine("Введите число являющееся его квадратом:");
int b = int.Parse( Console.ReadLine()!);
if (b == a * a)
{
    Console.WriteLine("Yes!");

}
else
{
    Console.WriteLine("NO!");
}