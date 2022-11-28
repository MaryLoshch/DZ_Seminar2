Console.WriteLine("Введите число, обозначающее день недели (от 1 до 7):  ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 5)
{
    if (num > 7)
    {
        Console.WriteLine("Попробуй еще раз выбрать число от 1 до 7 (включительно)");
    }
    else
    {
        Console.WriteLine("Да");
    }
}
else
{
    if(num < 1) 
    {
        Console.WriteLine("Попробуй еще раз выбрать число от 1 до 7 (включительно)");
    }
    else 
    {
        Console.WriteLine("Нет");
    }
}
