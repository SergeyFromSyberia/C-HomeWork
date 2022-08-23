Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
if (num % 2 == 0)
{
    while (count < num)
    {
        if (count % 2 == 0) Console.Write($"{count},");
        count++;
    }
    Console.WriteLine($"{count}.");
}
else if (num % 2 != 0)
{
    while (count < num-1)
    {
        if (count % 2 == 0) Console.Write($"{count},");
        count++;
    }
    Console.WriteLine($"{count}.");
}