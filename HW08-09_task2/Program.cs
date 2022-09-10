// Напишите программу, которая на вход принимает позиции 
//(две) элемента в двумерном массиве, и возвращает 
//значение этого элемента или же указание, что такого элемента нет.
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
Console.WriteLine("Введите координаты позиции элемента, значение которого надо узнать");
Console.Write("Укажите номер строки: ");
int strsNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите номер столбца: ");
int columnsNum = Convert.ToInt32(Console.ReadLine());
if (strsNum > arr.GetLength(0) || columnsNum > arr.GetLength(1))
{
    Console.Write("Такого элемента в массиве нет");
}
else
{
    Console.Write($"arr[{strsNum}, {columnsNum}] = {arr[strsNum, columnsNum]}");
}
