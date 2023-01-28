// 15. С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).
int N;
Console.Write("Введите число N: ");
N=Convert.ToInt32(Console.ReadLine());
if (N<0)
    {
    N=-N;
    };
if (N>99)
{
    while (N>999)
    {
        N=N/10;
    }
    N=N%10;
    Console.WriteLine ($"Третья цифра числа: {N}");
}
 else 
 {
    Console.WriteLine("NO");
 }






/*d0=N%10;
if (d0<=0)
    {
    d0=d0*-1;
    }
System.Console.WriteLine($"Последняя цифра в числе: {d0}");

*/