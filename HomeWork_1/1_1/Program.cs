Console.WriteLine("Здравствуйте Мария!");
Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine()!);

if (a>b)
{
    Console.WriteLine( $" Max = {a}; Min = {b}");
}
else if (a <b)
{
    Console.WriteLine( $" Max = {b}; Min = {a}" );
}
else 
{

Console.WriteLine("Ошибка! числа равны!");


}