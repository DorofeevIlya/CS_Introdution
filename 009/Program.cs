// 9. Вывести на экран четные числа от 1 до N
int i=2;
int N;
Console.Write("Введите N: ");
    N=Convert.ToInt32(Console.ReadLine());
System.Console.Write($"Четные числа из диапазона от 1 до {N}: ");
while(i<=N)
{
    System.Console.Write($"{i} ");
    i=i+2;
}