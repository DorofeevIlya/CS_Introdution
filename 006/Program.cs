// 6. Написать программу вычисления значения функции y = sin(a). (Класс Math). 
double a,y,x;
Console.Write("Угол в градусах от 0 до 360 = ");
         a = Convert.ToDouble(Console.ReadLine());
         x = a * Math.PI / 180;
         y = Math.Sin(x);
         Console.WriteLine($"sin({a})={y}");
        