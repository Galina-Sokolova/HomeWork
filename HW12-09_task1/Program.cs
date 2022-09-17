// Задайте двумерный массив. Напишите программу, которая будет
//находить строку с наименьшей суммой элементов.
//(допускается указывать индекс строки в массиве)
Console.Write("Введите количество строк в массиве: ");
int strsCount = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columnsCount = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[strsCount, columnsCount];
int[] arrSum = new int[strsCount];

Random rnd = new Random();
for (int i = 0; i < strsCount; i++)
    {
    for (int j = 0; j < columnsCount; j++)
        {
        arr [i, j] = rnd.Next(-10, 11);
             
        Console.Write(arr[i, j]+"\t");
        }
    Console.WriteLine();
    }

Console.WriteLine("Массив из построчных сумм элементов заданного массива: ");
for (int i = 0; i < strsCount; i++)
{
    int sum = 0;
    for (int j = 0; j < columnsCount; j++)
    {
        sum += arr[i, j];
    }
    arrSum[i] = sum;
}
System.Console.WriteLine(string.Join(" ", arrSum));

int min = arrSum[0];
int minIndex = 0;
for (int i = 0; i < arrSum.Length; i++)
{
    if (arrSum[i] < min)
    {
        min = arrSum[i];
        minIndex = i;
    }
}
Console.WriteLine($"В заданном массиве {minIndex+1} строка с наименьшей суммой");


