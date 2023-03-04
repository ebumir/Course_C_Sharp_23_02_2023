int TakeNum(int num)
{
 Console.WriteLine(num);
 int num1= (num /100) * 10;
 int num2= num % 10;
 return (num1+num2);
}

int result = TakeNum(new Random().Next(100,1000));
Console.WriteLine(result);
