// 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно полиндромом

Console.WriteLine("Программа проверки палиндромности пятизначного числа");
Console.Write("Введите пятизначное число и нажмите Enter: ");
int num = Convert.ToInt32(Console.ReadLine());

string Plndr(int n)
{
    if (n / 100000 == 0 && n / 10000 != 0)
    {
        if (n / 1000 == (n % 100 / 10) + (n % 10 * 10)) return $"{num} -> Да";
        return $"{num} -> Нет";
    } 
    return "Это не пятизначное число";
}

string result = Plndr(num);
Console.WriteLine(result);



// Первый вариант решения

// Console.WriteLine("Программа проверки палиндромности пятизначного числа");
// Console.Write("Введите пятизначное число и нажмите Enter: ");
// int num = Convert.ToInt32(Console.ReadLine());

// string Plndr(int n)
// {
//     if ((n < 10000 && n > 99999) || (n > -10000 && n < -99999)) return "Число не пятизначное";
//     if (n / 1000 == (n % 100 / 10) + (n % 10 * 10)) return $"{num} -> Да";
//     return $"{num} -> Нет";    
// }

// string result = Plndr(num);
// Console.WriteLine(result);


