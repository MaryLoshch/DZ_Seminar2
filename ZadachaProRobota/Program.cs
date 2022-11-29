Console.WriteLine("Введите число от 0 до 1000: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = num % 10;
if (i == 1 && num != 11) Console.WriteLine($" {num} програмист ");
if (i == 2 && num != 12 || i == 3 && num != 13 || i == 4 && num != 14) Console.WriteLine($" {num} програмиста ");
if (i == 5 || i == 6 || i == 7 || i == 8 || i == 9 || i == 0 || num == 11 || num == 12 || num == 13 || num == 14) Console.WriteLine($" {num} програмистов ");