/// Определение четности числа 2
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
if(n/2*2 == n)
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число является не четным");
}