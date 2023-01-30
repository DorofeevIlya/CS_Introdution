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
    d0=(int)N%(i/10);
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

/* Рабочая версия
// 13. Удалить вторую цифру целого числа введенного с клавиатуры
int N;
int i=0;
Console.Write("Введите число N: ");
N=Convert.ToInt32(Console.ReadLine());
int N1=N;
    while (N!=0)
   {
        i++;
        N/=10;
    }
    int d1=N1/(int)Math.Pow(10,i-1)%10;
    int d2=N1%(int)Math.Pow(10,i-2);
    Console.WriteLine($"{d1} + {d2}");
    Console.WriteLine(d1*Math.Pow(10,i-2)+ d2);
    */