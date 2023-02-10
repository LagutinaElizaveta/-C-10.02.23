// Вывод всех четных чисел
Console.WriteLine("Введите число: ");
int x = int.Parse(Console.ReadLine());
int y = 1;
while(y <= x)
{
    if(y % 2 == 0)
    {
        Console.Write(y + " , ");
        y++;
    }
    else
    {
        y++;
    }
}