// Задайте двумерный массив из целых чисел. Найдите среднее
//арифметическое элементов в каждом столбце.
Console.Write("Введите количество строк в массиве: ");
int strsCount = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columnsCount = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[strsCount, columnsCount];
//Заполнение массива случайными числами
Random rnd = new Random();
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr [i, j] = rnd.Next(-10, 10);
        Console.Write(arr[i, j]+"\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
//подсчет среднего арифметического по столбцам

for (int j = 0; j < arr.GetLength(1); j++)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
       sum = sum + arr[i, j]; 
    }
    double avr = Math.Round((double) sum / arr.GetLength(0), 2);
    Console.Write(avr+"\t");
}



