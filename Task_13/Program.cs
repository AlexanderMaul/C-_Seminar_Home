// 13. Напишите программу, которая выводит третью цифру заданнаго числа или сообщает, что третьей цифры нет

Console.WriteLine("Программа вывода третьей цифры заданного числа");
Console.WriteLine("Введите число и нажмите Enter");
int numA = Convert.ToInt32(Console.ReadLine());

int third (int num)
{
    while (num >= 1000) num = num/10;
    num = num % 10;
    return num;
}

int Third = third(numA);
string result = (numA < 100 && numA > -100) ? $"Третьей цифры нет" : Third.ToString();
Console.WriteLine($"{numA} -> {result}");

