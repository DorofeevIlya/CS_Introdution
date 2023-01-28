// 7. Выяснить является ли число чётным.

int A;
bool B;
Console.Write("Введите число A: " );
A=Convert.ToInt32(Console.ReadLine());
B=A%2==0;
if (B==true)
{
Console.WriteLine($"Число {A} четное");
}
else
{
Console.WriteLine($"Число {A} не четное");
}