// 6. Написать программу, которая на вход принимает число и выдаёт, является ли число чётным

Console.WriteLine("Программа проверки чётности числа ");
Console.WriteLine("Введите целое число ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0) Console.WriteLine($"Число {num} является чётным");
else Console.WriteLine($"Число {num} не является чётным");

