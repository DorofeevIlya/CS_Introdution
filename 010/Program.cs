// 10. Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 
int N,d0;
Console.WriteLine("Введите число N:");
N=Convert.ToInt32(Console.ReadLine());
d0=N%10;
if (d0<=0)
    {
    d0=d0*-1;
    }
System.Console.WriteLine($"Последняя цифра в числе: {d0}");

