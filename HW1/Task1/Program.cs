Console.WriteLine("Введите первое число:");
int num1 = int.Parse (Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = int.Parse (Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"Максимальное число {num1}");
}
else
{
    Console.WriteLine($"Максимальное число {num2}");
}