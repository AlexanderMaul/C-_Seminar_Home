// 8. Написать программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Программа нахождения всех чётных чисел от 1 до N ");
Console.WriteLine("Введите целое число ");
int num = Convert.ToInt32(Console.ReadLine());
int index = 2;

if (num <= 1) Console.WriteLine($"Число {num} меньше или равно 1. Введите число больше 1.");
else while (index <= num)
{
        Console.Write($"{index} ");
        index += 2;
}


// Комментарий преподавателя - По задачам 6 и 8 всё верно!