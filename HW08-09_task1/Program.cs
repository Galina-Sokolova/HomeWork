//  Задайте двумерный массив размером m×n, заполненный случайными вещественными
//(тип double) числами.
Console.Write("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] arr = new double[m, n];

Random rnd = new Random();
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr [i, j] = Math.Round(rnd.Next(-10, 10)+rnd.NextDouble(), 2);
        Console.Write(arr[i, j]+"\t");
    }
    Console.WriteLine();
}
