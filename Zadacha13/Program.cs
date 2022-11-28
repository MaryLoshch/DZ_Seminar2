// Работает до 99999
Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99)
{
    if (num > 999)
    {
        if (num > 9999)
        {
            if (num > 99999)
            {
                Console.WriteLine("Слишком большое число, здесь не справиться без строк :(");
            }
            else
            {
                int third = (num / 100) % 10;
                Console.WriteLine($"Третья цифра вашего числа: {third}");
            }
        }
        else
        {
            int third = (num / 10) % 10;
            Console.WriteLine($"Третья цифра вашего числа: {third}");
        }


    }
    else
    {
        int third = num % 10;
        Console.WriteLine($"Третья цифра вашего числа: {third}");
    }
}
else
{
    Console.WriteLine("Третьей цифры нет ");
}