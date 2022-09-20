// Задайте двумерный массив. Напишите программу, которая 
//упорядочит по убыванию элементы каждой строки двумерного массива.
//   индексы             сумма индексов
// 00 01 02 03   |       0 1 2 3 
// 10 11 12 13   |       1 2 3 4 
// 20 21 22 23   |       2 3 4 5
// 30 31 32 33   |       3 4 2 6 
Console.Write("Введите размерность квадратной матрицы, которую нужно заполнить: ");
int Size = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[Size, Size];
int count = 1;
int i = 0;
int j = 0;
while (count <= arr.GetLength(0) * arr.GetLength(1))
{
    arr [i, j] = count;
    count++;
    if (i <= j + 1 && i + j < arr.GetLength(1) - 1)
    {
        j++;
    }        
        else if (i < j && i + j >= arr.GetLength(0) - 1)
        {
            i++;
        }
        else if (i >= j && i + j > arr.GetLength(1) - 1)
        {
            j--;
        }
        else
        {
            i--;
        }           
}
void PrintArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
    {
    for (int j = 0; j < array.GetLength(1); j++)
        {                   
        Console.Write(array[i, j]+"\t");
        }
    Console.WriteLine();
    }
}    
PrintArray(arr);

