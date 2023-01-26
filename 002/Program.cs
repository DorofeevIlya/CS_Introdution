// 2. С клавиатуры вводятся два вещественных числа. Проверять является ли одно из них квадратом второго
double a,b;
string s;
s=Console.ReadLine();
a=Convert.ToDouble(s);
s=Console.ReadLine();
b=Convert.ToDouble(s);
if (a*a==b)
System.Console.WriteLine("b является квадратом а");
if (b*b==a)
System.Console.WriteLine("a является квадратом b");
