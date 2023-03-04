Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);
void Week(int num1)
{
    if (num1>0)
    {
        int num = num1 % 7;
        if (num>0 && num<6)
        {
            Console.WriteLine("working days");
        }
        else if (num ==0)
        {
            Console.WriteLine("Weekend!!!");
        }
        else if (num >5)
        {
            Console.WriteLine("Weekend!!!");
        }
    }
    else
    {
        Console.WriteLine("Число должно быть больше 0!");
    }
}

Week(a);
