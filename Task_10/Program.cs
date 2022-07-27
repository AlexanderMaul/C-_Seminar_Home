// 10/ Напишите программу, которая принимает на входе трёхзначное число и на выходе показывает вторую цифру этого числа

Console.WriteLine("Программа преобразования числа по заданию");
Console.WriteLine("Введите трёхзначное число и нажмите Enter");
int numA = Convert.ToInt32(Console.ReadLine());

int second (int num)
{
    int second = num % 100 / 10;
    if ((num >= 100 && num <= 999) || (num <= -100 && num >= -999)) return second;
    return 0;       
}

int Second = second(numA);
string result = Second != 0 ? Second.ToString() : "Число не является трёхзначным";
Console.WriteLine($"{numA} -> {result}");

