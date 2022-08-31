// программа, которая принимает на вход число и выдаёт
//сумму цифр в числе, которые являются делителями этого числа.
Console.Write("Введите число а = ");
int A = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int num = A;
while ( num != 0 )
{
    int rem = num % 10;
    int rem1 = A % rem;
    num /= 10;
    if (rem1 == 0) 
    {
        sum = sum + rem;
    }
}
Console.Write("сумма цифр, которые являются делителями числа "+A+" = "+sum);

