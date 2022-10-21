// 15. Напишите программу, которая принимаетна вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.WriteLine("Программа проверки дня недели на выходной");
Console.WriteLine("Введите номер дня недели (от 1 до 7)");
int numDay = Convert.ToInt32(Console.ReadLine());

string weekend(int num)
{
    if (num < 1 || num > 7)
    {
        string result = "Нет такого дня";
        return result;
    }
    else
    {
        if (num <= 5) 
        {
            string result = $"{numDay} -> Нет";
            return result;
        }
        else
        {
            string result = $"{numDay} -> Да";
            return result;
        }
    }
}
Console.WriteLine(weekend(numDay));

