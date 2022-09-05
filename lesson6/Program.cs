Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[100];
int i = 0;
int count = 0;
while (N > 0)
{
    arr[i] = N % 2;
    N = N / 2;
    Console.Write(arr[i]+" ");
    i++;
    count += 1;
}
Console.WriteLine(" ");
for (i = count - 1; i >= 0; i --)
{
  Console.Write(arr[i]+" ");  
}
