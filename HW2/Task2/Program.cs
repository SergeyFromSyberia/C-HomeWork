// Задача 13: Напишите программу, которая
// 1. выводит третью цифру заданного числа или
// 2. сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите трёхзначное число");
// int num = Convert.ToInt32(Console.ReadLine());
// int num1 = 10;
// int result = 0;
// int number = 0;
// if (num > 100 && num < 1000)
// {
// result = num % 10;
// Console.WriteLine(result);
// }
// while (num > 999)
// {
//  num = num / num1;
//  number = num % num1;
// }
// Console.WriteLine(number);
// if (num < 100) Console.WriteLine("третьей цифры нет");

Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = 10;
int result = 0;
while (num > 999)  num = num / num1;
if (num > 99 && num < 1000)
{
result = num % 10;
Console.WriteLine(result);
}
if (num < 100) Console.WriteLine("третьей цифры нет");