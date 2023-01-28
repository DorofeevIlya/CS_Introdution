// 3. С клавиатуры вводятся два числа a и b. Найти максимальное из них.
double a,b;
Console.Write("Введите число a: ");
a=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b: ");
b=Convert.ToDouble(Console.ReadLine());
if (a>b)
System.Console.WriteLine($"{a} является максимумом");
if (b>a)
System.Console.WriteLine($"{b} является максимумом");
if (a==b)
System.Console.WriteLine($"{b} равно {a}");
