// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//является ли оно палиндромом.
Console.Write("Введите целое число: ");
int input = Convert.ToInt32(Console.ReadLine());
//переменная для записи обратного числа
int recNum = 0;
int Num = input;
while (Num != 0)
{
    recNum = recNum * 10 + Num % 10;
    Num /= 10;
}
//Console.WriteLine(recNum);
if (recNum == input)
{
    Console.WriteLine("Число "+input+" является палиндромом");
}
else
{
    Console.WriteLine("Число "+input+" не является палиндромом");
}