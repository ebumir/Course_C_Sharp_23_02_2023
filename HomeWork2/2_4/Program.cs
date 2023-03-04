Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);
void Week(int num1)
{
    if (num1>0)
    {
        int num = num1 % 7;
    
        if (num<6)
        {
            if( num == 0)
            {
                Console.WriteLine ("Sunday. Weekend");
            }
            if ( num == 1)
            {
                Console.WriteLine ("Monday");
            }
            else if ( num == 2)
            {
                Console.WriteLine ("Tuesday");
            }
            else if ( num == 3)
            {
                Console.WriteLine ("Wednesday");
            }
            else if ( num == 4)
            {
                Console.WriteLine ("Thursday");
            }
            else if ( num == 5)
            {
                Console.WriteLine ("Friday");
            }

        }
        else
        {
            if (num==7)
            {
                Console.WriteLine ("Sunday. Weekend");
            }
            else if (num==6)
            {
                Console.WriteLine ("Saturday. Weekend");
            }
        }
    }
    else
        Console.WriteLine("Число должно быть больше 0!");
}

Week(a);