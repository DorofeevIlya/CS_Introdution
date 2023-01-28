// 12. С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа
int d0,d1,N;
Console.WriteLine("Введите целое число из диапазона [10, 99]:");
N=Convert.ToInt32(Console.ReadLine());
if ((9<N) & (N<100))
    {
    d0=N%10;
    d1=N/10%10;
        if (d0>d1)
        {System.Console.WriteLine($"Наибольшая цифра в числе: {d0}");}
        if (d1>d0)
        {System.Console.WriteLine($"Наибольшая цифра в числе: {d1}");}
        if (d0==d1)
        {System.Console.WriteLine($"Цифры в числе равны: {d0}");}
    }
else {System.Console.WriteLine($"Введено число, не входящее в диапазон. Ошибка");}
