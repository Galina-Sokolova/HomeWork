// Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму четных элементов, стоящих на нечётных позициях
//(позиция - индекс элемента в массиве).
Console.Write("Введите число - количество элементов в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
int start = -999;
int stop = 1000;
int[]array = new int[N];
Random rnd = new Random();
int sum = 0;
Console.Write("Массив: ");
for (int index = 0; index < N; index++)
{
    array[index] = rnd.Next(start, stop);
    Console.Write(array[index]+" ");    
}
Console.WriteLine("");
Console.Write("Сумма четных элементов: ");
for(int index = 1; index < N; index+=2)
{
    int rem = array[index] % 2;
        if (rem == 0)
        {
            sum += array[index];
            Console.Write("array["+index+"] ");
        }
}
Console.Write("= "+sum);

