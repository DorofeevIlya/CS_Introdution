// 1. С клавиатуры вводится целое число. Вывести квадрат числа 

string? S;
int A;
S=Console.ReadLine ();

Console.WriteLine(S);
A=Convert.ToInt32(S);
Console.WriteLine(Math.Pow (A,2));
