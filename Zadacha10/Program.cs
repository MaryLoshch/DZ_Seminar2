Console.WriteLine("Введите трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());
string array = Convert.ToString(num);

Console.WriteLine($"Вторая цифра введенного числа: {array[1]}");
