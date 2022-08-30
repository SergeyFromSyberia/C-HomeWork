Console.WriteLine("Введите число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
if (num >=1 && num<=5) Console.WriteLine("Нет");
else if (num==6||num==7) Console.WriteLine("Да");
else Console.WriteLine("Введите число до 7 включительно");