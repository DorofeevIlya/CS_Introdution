// 13. Удалить вторую цифру целого числа введенного с клавиатуры
int N,M,d0,d2;
int i=1;
Console.Write("Введите число N: ");
N=Convert.ToInt32(Console.ReadLine());
M=N;
if (N<0)
{
    N=-N;
}

    while (N>9)
   {
    i=i*10;
    N=N/10;
    }
N=M;
if (N>9)
{
    d0=N%(i/10);
    d2=N/i;
    if(d0==0)
    {
    System.Console.WriteLine($"Новое число: {d2}");
    }
    else
    System.Console.WriteLine($"Новое число: {d2} {d0}");  
}
else 
 {
    Console.WriteLine("Нет второй цифры");
 }

