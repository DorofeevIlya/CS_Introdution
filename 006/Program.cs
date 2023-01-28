// 6. Написать программу вычисления значения функции y = sin(a). (Класс Math). 

Console.Write("Угол в градусах от 0 до 360 = ");
         double x = Convert.ToDouble(Console.ReadLine());
         double a, y;
         a = x * Math.PI / 180;
         Console.WriteLine("Угол в радианах = {0}",a);
         y = Math.Sin(a);
         Console.WriteLine("sin({0})={1}",a,y);
        