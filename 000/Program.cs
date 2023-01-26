// С клавиатуры вводятся два числа, найти и вывести их сумму на экран

// string s;
int a,b,sum;
System.Console.WriteLine("Введите a: ");
a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите b: ");
b=Convert.ToInt32(Console.ReadLine());
sum=a+b;
System.Console.WriteLine(a+"+"+b.ToString()+"="+Convert.ToString(sum));
System.Console.WriteLine("{0:F2}+{1:E5}={2:G4}",a,b,sum);
System.Console.WriteLine($"{a}+{b}={sum}");

// С клавиатуры вводятся два числа, найти и вывести на экран максимальное из них

int max;
if (a>b)
    max=a;
else 
    max=b;
System.Console.WriteLine($"max={max}");