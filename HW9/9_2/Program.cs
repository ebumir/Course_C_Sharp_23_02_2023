//Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N с помощью рекурсии.

int SumFromTo (int a, int b)
{
    if(b==a) return 0;
    return b + SumFromTo (a,b-1);
}

Console.WriteLine("enter first the number:");
int Number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter second the number:");
int Number2 = int.Parse(Console.ReadLine()!);

int res = SumFromTo (Number1, Number2);
System.Console.WriteLine(res-Number2);