// 4. По заданному с клавиатуры номеру дня недели вывести его название
Console.WriteLine("Введите число от 1 до 7 ");
string? S;
int A;
S=Console.ReadLine ();
Console.WriteLine(S);
A=Convert.ToInt32(S);
if (A==1)
Console.WriteLine("Понедельник");
if (A==2)
Console.WriteLine("Вторник");
if (A==3)
Console.WriteLine("Среда");
if (A==4)
Console.WriteLine("Четверг");
if (A==5)
Console.WriteLine("Пятница");
if (A==6)
Console.WriteLine("Суббота");
if (A==7)
Console.WriteLine("Воскресенье");