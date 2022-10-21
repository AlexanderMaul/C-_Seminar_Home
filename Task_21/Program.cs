// 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

Console.WriteLine("Программа нахождения расстояния между точками А и В в 3Д пространстве");

Console.WriteLine("Введите координаты точки А");
Console.Write("Введите координату Х: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.Write("Введите координату X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

// Вариант из семинара
// double Dist (int x1c, int y1c, int x2c, int y2c, int z1c, int z2c)
// {
//     int cat1 = 0;
//     int cat2 = 0;
//     int cat3 = 0;
//     double result = 0.0;

//     cat1 = x1c - x2c;
//     cat2 = y1c - y2c;
//     cat3 = z1c - z2c;
//     result = Math.Sqrt(cat1 * cat1 + cat2 * cat2 + cat3 * cat3);
//     return Math.Round(result,2);
// }

// Упрощаем решение
double Dist (int x1c, int y1c, int x2c, int y2c, int z1c, int z2c)
{ 
    double result = Math.Sqrt(Math.Pow(x1c - x2c, 2) + Math.Pow(y1c - y2c, 2) + Math.Pow(z1c - z2c, 2));
    return Math.Round(result,2);
}

double result = Dist(x1, y1, x2, y2, z1, z2);
Console.WriteLine($"Растояние между точками A и B: {result}");

