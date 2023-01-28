// 13. Удалить вторую цифру целого числа введенного с клавиатуры
int d1,n;
Console.WriteLine("Введите целое число:");
n=Convert.ToInt32(Console.ReadLine());
d1=n/10%10;
System.Console.WriteLine($"{d1}");
