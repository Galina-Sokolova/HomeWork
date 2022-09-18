// Задайте двумерный массив. Напишите программу, которая упорядочит
//по убыванию элементы каждой строки двумерного массива.
void SortArray(int[,] array, int i)
{

for (int j = 0; j < array.GetLength(1); j++)
    {
        int max = array [i, j];
        int jMax = j;
        for (int k = j+1; k < array.GetLength(1); k++)
        {
            if (array[i, k] > max)
            {
                max = array [i, k];
                jMax = k;
            }
            
        }
        if (max != array[i, j])
        {
            int temp = array [i, j]; 
            array [i, j] = max;  
            array [i, jMax] = temp;  
        }            
        Console.Write(array[i, j]+"\t");

    }
    Console.WriteLine();
}
Console.Write("Введите количество строк в массиве: ");
int strsCount = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columnsCount = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[strsCount, columnsCount];

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
Console.WriteLine("Упорядоченный массив:");    

for (int i = 0; i < arr.GetLength(0); i++)
{
  SortArray (arr, i);  
}
