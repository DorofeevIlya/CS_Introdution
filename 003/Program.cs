// 3. С клавиатуры вводятся два числа a и b. Найти максимальное из них.
double a,b;
string? s;
s=Console.ReadLine();
a=Convert.ToDouble(s);
s=Console.ReadLine();
b=Convert.ToDouble(s);
if (a>b)
System.Console.WriteLine($"{a} является максимумом");
if (b>a)
System.Console.WriteLine($"{b} является максимумом");
if (a==b)
System.Console.WriteLine($"{b} равно {a}");
