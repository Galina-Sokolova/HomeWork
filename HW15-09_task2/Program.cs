// Напишите программу, которая спирально заполнит числами
//от 1 до 16 двумерный массив 4 на 4.
Console.Write("Введите размерность квадратной матрицы, которую нужно заполнить: ");
int Size = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[Size, Size];

int count = 1;
for (int k = 0; k < arr.GetLength(0)/2; k++)
{
    for (int j = k; j < arr.GetLength(1)-k; j++)
    {
        arr [k, j] = count;
        count++;
    }    
    for (int i = k + 1; i < arr.GetLength(0) - k; i++)
        {
            int j = arr.GetLength(1) - 1 - k;
            arr [i, j] = count;
            count++;
        }    
    for (int j = arr.GetLength(1) - 2 - k; j >= k; j--)
        {
            int i = arr.GetLength(0) - 1 - k;               
            arr [i, j] = count;
            count++;
        }    
    for (int i = arr.GetLength(0) - 2 - k; i > k; i--)
        {
            int j = k;
            arr [i, j] = count;
            count++;
        }
}
if (Size % 2 != 0)
{
    arr [arr.GetLength(0)/2, arr.GetLength(1)/2] = arr.GetLength(0) * arr.GetLength(1);
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
