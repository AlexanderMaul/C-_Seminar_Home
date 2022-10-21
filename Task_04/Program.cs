// 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.WriteLine("Программа поиска максимального числа из трёх ");
Console.WriteLine("Введите первое целое число и нажмите Enter \nВведите второе целое число и нажмите Enter \nВведите третье целое число и нажмите Enter ");
int num_A = Convert.ToInt32(Console.ReadLine());
int num_B = Convert.ToInt32(Console.ReadLine());
int num_C = Convert.ToInt32(Console.ReadLine());
if(num_A > num_B && num_A > num_C) Console.WriteLine($"Число {num_A} является максимальным из трёх");
else if(num_B > num_C) Console.WriteLine($"Число {num_B} является максимальным из трёх");
else if(num_C > num_B) Console.WriteLine($"Число {num_C} является максимальным из трёх");
else if(num_A == num_B && num_A == num_C) Console.WriteLine($"Все числа равны. Введите три разных числа.");
else Console.WriteLine($"Два числа из трёх равны. Введите три разных числа.");
