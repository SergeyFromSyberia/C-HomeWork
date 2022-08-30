// Задача 10: Напишите программу, которая
// 1. принимает на вход трёхзначное число
// 2. и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трёхзначное число");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = num / 10;
// int finish = result % 10;
// Console.WriteLine(finish);

Console.WriteLine("Введите трёхзначное число");
int numb = Convert.ToInt32(Console.ReadLine());
int Method(int num)
{
    num = num / 10;
    num = num % 10;
    return num;
}
int result = Method(numb);
Console.WriteLine(result);