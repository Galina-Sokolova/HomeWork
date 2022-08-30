// Напишите программу, которая принимает на вход число (N) 
//и помещает в массив таблицу кубов чисел от 1 до N.
//Полученный массив вывести на экран.
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int [] array = new int [num];
int tmp = 1;
for (int index = 0; index < num; index++ )
{
    array[index] = Convert.ToInt32(Math.Pow(tmp, 3));
    Console.Write(array[index]+" ");
    tmp++;
}

