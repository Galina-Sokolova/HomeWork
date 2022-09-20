// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
uint CalculatAckerman(uint m, uint n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m != 0 && n == 0)
    {
        return CalculatAckerman(m - 1, 1);
    }
    else
    {
        return CalculatAckerman(m - 1, CalculatAckerman(m, n - 1));
    }
}
Console.Write("Введите неотрицательное целое число, m = ");
uint m = Convert.ToUInt32(Console.ReadLine());
Console.Write("Введите неотрицательное целое число, n = ");
uint n = Convert.ToUInt32(Console.ReadLine());
uint result;
result = CalculatAckerman(m, n);
Console.WriteLine($"A({m}, {n}) = {result}");
//result = CalculatAckerman(0, 1);
//Console.WriteLine(result);
//result = CalculatAckerman(2, 2);
//Console.WriteLine(result);
//result = CalculatAckerman(0, 0);
//Console.WriteLine(result);