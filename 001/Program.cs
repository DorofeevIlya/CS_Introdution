// 1. С клавиатуры вводится целое число. Вывести квадрат числа. 

int A;
Console.Write("Введите число A: ");
A=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Квадрат числа {A} = {Math.Pow (A,2)}");
