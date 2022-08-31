// Назовём число «интересным» если его произведение цифр делится на их сумму.
// Напишите программу, которая заполняет массив на N «интересных» случайных 
// целых чисел. (Каждый эл-т массива должен быть сгенерирован случайно)
Console.Write("Введите число - какое количество интересных чисел Вы хотите получить: ");
int N = Convert.ToInt32(Console.ReadLine());
int[]array = new int[N];
int index = 0;
while (index < N)
{
    int rand = new Random().Next(1, 10000);
    int sum = 0;
    int prod = 1;
    int num = rand;
    //проверка, является ли число "интересным"
    while (num != 0)
    {
        int rem = num % 10;
        sum = sum + rem;
        prod = prod * rem;
        num /= 10;
    }
    int result = prod % sum;
        if (result == 0)
        {
            array[index] = rand;
            Console.Write(rand+" ");
             index++;
        }
}
