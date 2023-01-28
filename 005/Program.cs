// 5. С клавиатуры вводятся три числа. Найти максимальное из трех чисел
double a,b,c,max;
string? s;
Console.WriteLine("Введите a:");
s=Console.ReadLine();
a=Convert.ToDouble(s);
Console.WriteLine("Введите b:");
s=Console.ReadLine();
b=Convert.ToDouble(s);
Console.WriteLine("Введите c:");
s=Console.ReadLine();
c=Convert.ToDouble(s);
max=a;

if (a>max)
max=a;  
if (b>max)
max=b; 
if (c>max)
max=c; 
System.Console.WriteLine($"{max} является максимумом");

