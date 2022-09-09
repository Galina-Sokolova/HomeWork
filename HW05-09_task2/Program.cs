// Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения
//b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Задайте первую линейную функцию");
Console.Write("Введите угловой коэффициент k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите свободный коэффициент b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Задайте вторую линейную функцию");
Console.Write("Введите угловой коэффициент k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите свободный коэффициент b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());
if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Графики заданных линейных функций совпадают");
}
if (k1 == k2 && b1 != b2)
{
    Console.WriteLine("Графики заданных линейных функций параллельны");
}
if (k1 != k2)
{
    double X = (b2 - b1)/(k1 - k2);
    double Y = k1 * X + b1;
    Console.WriteLine($"Графики заданных линейных функций пересекаются в точке с координатами ({X}, {Y})");
}
