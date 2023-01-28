// 14. С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.
double a,b,d;
Console.WriteLine("Введите число a:");
a=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b:");
b=Convert.ToDouble(Console.ReadLine());
d=a%b;
if (d==0)
    {
        System.Console.WriteLine($"{a} кратно {b}");
    }
else
    {
        System.Console.WriteLine($"Остаток от деления: {d}"); 
    }