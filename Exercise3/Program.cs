//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.WriteLine("Введите цифру от 1 до 7 : ");
int num = Convert.ToInt32(Console.ReadLine());
string[] DaysOfWeek = {"Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"};
if (num>=1&&num<=5)
{
    string result = DaysOfWeek[num - 1];
    Console.WriteLine($"{result} - Это будний день . ");
}
if (num==6)
{
    string num6 = DaysOfWeek[num - 1];
    Console.WriteLine($"{num6} - Это выходной");
}
if (num==7)
{
    string num7 = DaysOfWeek[num - 1];
    Console.WriteLine($"{num7} - Это выходной");
}