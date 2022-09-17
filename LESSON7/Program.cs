//СОСТАВЛЕНИЕ ЧАСТОТНОГО СЛОВАРЯ ЭЛ-В ДВУХМЕРНОГО МАССИВА ИЗ ЦЕЛЫХ
//ЧИСЕЛ ОТ 0 ДО 9. ЧАСТОТНЫЙ СЛОВАРЬ СОДЕРЖИТ ИГФО О ТОМ, СКОЛЬКО
//РАЗ ВСТРЕЧАЕТСЯ ЭЛЕМЕНТ ВО ВХЛДНЫХ ДАННЫХ.
//ЧАСТОТНЫЙ СЛОВАРЬ - ОДНОМЕРНЫЙ МАССИВ.
Console.Write("Введите количество строк в массиве: ");
int strsCount = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columnsCount = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[strsCount, columnsCount];
int[] array = new int [10];
int k = 0;
Random rnd = new Random();
for (int i = 0; i < arr.GetLength(0); i++)
    {
    for (int j = 0; j < arr.GetLength(1); j++)
        {
        arr [i, j] = rnd.Next(0, 10);
             
        Console.Write(arr[i, j]+"\t");
        }
    Console.WriteLine();
    }
    

for ( k = 0; k < 10; k++)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
    for (int j = 0; j < arr.GetLength(1); j++)
        {

        if (arr[i, j] == k)
         {
            array[k]++;
         }
                        
        }
    }
}    
System.Console.WriteLine(string.Join(" ", array));




      