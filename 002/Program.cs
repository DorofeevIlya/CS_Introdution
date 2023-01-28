// 2. С клавиатуры вводятся два вещественных числа. Проверять является ли одно из них квадратом второго
double A,B;
Console.Write("Введите число A:");
A=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число B:");
B=Convert.ToDouble(Console.ReadLine());
if (A*A==B)
{
System.Console.WriteLine($"{B} является квадратом {A}");
}
if (B*B==A)
{
System.Console.WriteLine($"{A} является квадратом {B}");
}
else
{
System.Console.WriteLine($"{A} и {B} не являются квадратами друг друга");
}