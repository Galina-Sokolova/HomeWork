// Сформируйте двухмерный массив из неповторяющихся
//двузначных чисел (размер массива не более 50 элементов). 
//Напишите программу, которая будет построчно выводить массив.

int prod;
int strsCount;
int columnsCount;
//ввод размера массива
do 
{
    Console.Write("Введите количество строк в массиве: ");
    strsCount = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов в массиве: ");
    columnsCount = Convert.ToInt32(Console.ReadLine());
    prod = strsCount * columnsCount;
    if (prod > 90)
    {
      Console.WriteLine("столько уникальных двузначных чисел не существует");
    } 
}
while (prod > 90);

//проверка числа на уникальность
bool Contains(int[,] arr, int value)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j =0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == value)
            {
                return true;
            }
        }
    }
    return false;
}

//заполнение массива уникальными двухзначными числами
int[,] array = new int[strsCount, columnsCount];
Random rnd = new Random();
int tmp;
for (int i = 0; i < strsCount; i++)
    {
        for (int j =0; j < columnsCount; j++)
        {
            do
            {
                 tmp = rnd.Next(10, 100);

            }while (Contains(array, tmp) == true);
            array[i, j] = tmp;  
            Console.Write(array[i, j]+"\t");          
        }
        Console.WriteLine();
    }