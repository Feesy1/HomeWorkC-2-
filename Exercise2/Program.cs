// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число от 0 до 99999. ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num);
if (num>=0&&num<=99)
{
    Console.WriteLine("Третьей цифры нет . ");
}
if (num>=100&&num<=999)
{
    int result = num % 10;
    Console.WriteLine(result);
}
if (num>=1000&&num<=9999)
{
    int result = num % 100;
    int result1 = result / 10;
    Console.WriteLine(result1);
}
else
{
    int result = num % 1000;
    int result1 = result / 100;
    Console.WriteLine(result1);
}
