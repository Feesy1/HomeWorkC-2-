Console.WriteLine("Введите число N от 1 до 1000");
int n = Convert.ToInt32(Console.ReadLine());
if (n==0)
{
    Console.WriteLine($"{n} программистов . ");
}
if (n>=1&&n<=10)
{
    if (n==1)
    {
        Console.WriteLine($"{n} программист");
    }
    if (n>1&&n<=4)
    {
        Console.WriteLine($"{n} программиста");
    }
    if (n>4&&n<=10)
    {
        Console.WriteLine($"{n} программистов");
    }
}
if (n>=11&&n<=20)
{
    Console.WriteLine($"{n} программистов");
}
if (n>=21&&n<=999)
{
    if (n % 10==1)
    {
        Console.WriteLine($"{n} программист");
    }
    if (n % 10 >=2 && n % 10 <= 4)
    {
        Console.WriteLine($"{n} программиста");
    }
    if (n % 10 >=5 || n % 10 == 0)
    {
        Console.WriteLine($"{n} программистов");
    }
}
else if (n == 1000)
{
    Console.WriteLine($"{n} программистов ");
}

    