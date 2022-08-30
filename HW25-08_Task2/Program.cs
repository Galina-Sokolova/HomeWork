// Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.
Console.Write("Введите координаты точки A: x1 = ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1 = ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1 = ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите координаты точки B: x2 = ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2 = ");
int y2 = Convert.ToInt32(Console.ReadLine());            
Console.Write("z2 = ");
int z2 = Convert.ToInt32(Console.ReadLine());
double X = Math.Pow(x2 - x1, 2);
double Y = Math.Pow(y2 - y1, 2);
double Z = Math.Pow(z2 - z1, 2);
double dist = Math.Sqrt(X + Y + Z);
dist = Math.Round(dist, 2);
Console.WriteLine("Расстояние AB = "+dist);
