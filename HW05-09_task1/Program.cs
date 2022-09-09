// Программа запрашивает натуральное число M, пользователь
// вводит с клавиатуры M чисел. Посчитайте, сколько 
// чисел больше 0 ввёл пользователь.
Console.WriteLine("Сколько чисел Вы хотите ввести?");
int M = Convert.ToInt32(Console.ReadLine());
int count = 0;
int i = 1;
while (i <= M)
{
    Console.Write($"Введите число {i}: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) count++;
    i++;
}
Console.Write($"Вы ввели {count} положительных чисел");
