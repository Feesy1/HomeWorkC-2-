// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.
//456 -> 5
//782 -> 8
//918 -> 1
int num = new Random().Next(100,999);
Console.WriteLine(num);
int middlenum = num % 100 / 10;
Console.WriteLine(middlenum);