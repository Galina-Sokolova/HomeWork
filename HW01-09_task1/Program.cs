// Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Write("Введите число - количество элементов в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
int start = 100;
int stop = 1000;
int[]array = new int[N];
Random rnd = new Random();
int count = 0;
Console.Write("Массив: ");
for (int index = 0; index < N; index++)
{
    array[index] = rnd.Next(start, stop);
    Console.Write(array[index]+" ");
    int rem = array[index] % 2;
    if (rem == 0)
    {
        count++;
    }
}
Console.WriteLine("");
Console.Write($"В данном массиве количество четных чисел = {count}");
