// Задайте значения M и N. Напишите программу, которая выведет все чётные
//натуральные числа в промежутке от M до N с помощью рекурсии.

void EvenFromTo(int a, int b)
{
    if (b<a) return;
    if (b%2==1)
    {
        b-=1;
        EvenFromTo(a,b-2);
    }
    else 
    EvenFromTo(a,b-2);

        
    System.Console.Write($"{b}; ");
           
    
}

Console.WriteLine("enter first the number:");
int Number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter second the number:");
int Number2 = int.Parse(Console.ReadLine()!);

EvenFromTo(Number1,Number2);