// 2. Напишите программу, которая принимает два числа и выдаёт, какое число большее, а какое меньшее

Console.WriteLine("Программа сравненния двух чисел ");
Console.WriteLine("Введите первое целое число и нажмите Enter \nВведите второе целое число и нажмите Enter ");
int num_A = Convert.ToInt32(Console.ReadLine());
int num_B = Convert.ToInt32(Console.ReadLine());
if(num_A > num_B) Console.WriteLine($"Число {num_A} является большим, а число {num_B} является меньшим");
else Console.WriteLine($"Число {num_B} является большим, а число {num_A} является меньшим");

