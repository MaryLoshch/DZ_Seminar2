// Разные решения, оба работают
for (int i = 1; i <= 100; i++)
{
    if (i % 15 == 0) Console.Write("FizzBuzz ");
    if (i % 3 == 0) Console.Write("Fizz ");
    if (i % 5 == 0) Console.Write("Buzz ");
    else Console.Write($"{i} ");
}

// for (int i = 1; i <= 100; i++)
// {
//     if (i % 3 != 0 & i % 5 != 0) Console.Write($"{i} ");
//     if (i % 3 == 0) Console.Write("Fizz ");
//     if (i % 5 == 0) Console.Write("Buzz ");
//     if (i % 3 == 0 & i % 5 == 0) Console.Write("FizzBuzz ");
// }


