// Задайте массив натуральных чисел. Найдите разницу
//между максимальным и минимальным элементов массива.
Console.Write("Введите число - количество элементов в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
int start = 1;
int stop = 10000;
int[]array = new int[N];
Random rnd = new Random();
Console.Write("Массив: ");
for (int index = 0; index < N; index++)
{
    array[index] = rnd.Next(start, stop);
    Console.Write(array[index]+" ");    
}
int maxNum = array[0];
int minNum = array[0];
int maxIndex = 0;
int minIndex = 0;
for (int index = 1; index < N; index++)
if (array[index] > maxNum)
{
    maxNum = array[index];
    maxIndex = index;
}
else
{
    if (array[index] < minNum)
    {
        minNum = array[index];
        minIndex = index;
    }
}
int diff = maxNum - minNum;
Console.WriteLine();
Console.Write($"array[{maxIndex}](max) - array[{minIndex}](min) = {diff}");