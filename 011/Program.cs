// 11. Дано число больше 9. Вывести на экран  вторую цифру числа с конца

int N,d;
Console.Write("Введите число N: ");
N=Convert.ToInt32(Console.ReadLine());
if (N>9)
{   N=N/10; 
    d=N%10;
    System.Console.WriteLine($"Вторая цифра с конца: {d}");
}
else 
 {
    Console.WriteLine("Введено число меньше 10");
 }
