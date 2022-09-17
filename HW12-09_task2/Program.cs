// Задайте две квадратные матрицы одного размера. Напишите программу,
//которая будет находить произведение двух матриц.
Console.Write("Введите порядок квадратных матриц, произведение которых надо найти: ");
int order = Convert.ToInt32(Console.ReadLine());
int[,] array1 = new int[order, order];
int[,] array2 = new int[order, order];
int[,] arrayProd = new int[order, order];

void FillingPrintArray(int[,] array)
{
Random rnd = new Random();
for (int i = 0; i < array.GetLength(0); i++)
    {
    for (int j = 0; j < array.GetLength(1); j++)
        {
        array [i, j] = rnd.Next(1, 10);            
        Console.Write(array[i, j]+"\t");
        }
    Console.WriteLine();
    }
}    
Console.WriteLine("Матрица A:");
FillingPrintArray(array1);
Console.WriteLine("Матрица B:");
FillingPrintArray(array2);
Console.WriteLine("Произведение матриц A*B:");
for (int i = 0; i < order; i++)
    {
    for (int j = 0; j < order; j++)
        {
            for(int n = 0; n < order; n++)
            {
                arrayProd [i, j] += array1[i, n] * array2[n, j];

            }         
             
        Console.Write(arrayProd[i, j]+"\t");
        }
    Console.WriteLine();
    }
