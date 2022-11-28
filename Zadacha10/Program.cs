Console.WriteLine("Введите трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());
int second = num % 100 / 10;
Console.WriteLine($"Вторая цифра введенного числа: {second}");
