// 8. Вывести на экран числа от -N до N

int N,M;
Console.Write("Введите N:");
    N=Convert.ToInt32(Console.ReadLine());
    M=-N;
while(M<=N)
{
    System.Console.Write($" {M} ");
    M=M+1;
}

