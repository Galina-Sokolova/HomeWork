// Найдите сумму произведений пар чисел в одномерном целочисленном
//массиве. Парой считаем первый и последний элемент, второй 
//и предпоследний и т.д. Если кол-во элементов нечетное, 
//то элемент посередине не учитывать.Результат сложения вывести на экран.
Console.Write("Введите число - количество элементов в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N]; 
Random rnd = new Random();
for (int index = 0; index < N; index++)
{
    array[index] = rnd.Next(-10, 10);
    Console.Write(array[index]+" ");
}
Console.WriteLine();
int sum = 0;
for (int index = 0; index < N/2; index++)
{
    int tmp = array[index] * array[N-1-index];
    sum = sum + tmp;
}
Console.Write(sum);

