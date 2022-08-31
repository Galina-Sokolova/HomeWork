// цикл, который принимает на вход два числа (A и B) и возводит
//число A в натуральную степень B. Не использовать функцию Math.Pow()
Console.Write("Введите число а = ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число b = ");
uint B = Convert.ToUInt32(Console.ReadLine());
int tim;
int prod = 1;
for (tim = 1; tim <= B; tim++)
{
    prod = prod * A;
}
Console.Write("a ^ b = "+A+" ^ "+B+" = "+prod);
