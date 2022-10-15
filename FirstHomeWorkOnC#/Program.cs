// Задача №2. Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// int number1;
// Console.Write("Введите первое число: ");
// while (!int.TryParse(Console.ReadLine(), out number1))
// {
//     Console.WriteLine("Ошибка ввода! Введите целое ЧИСЛО!!!");
// }

// int number2;
// Console.Write("Введите второе число: ");
// while (!int.TryParse(Console.ReadLine(), out number2))
// {
//     Console.WriteLine("Ошибка ввода! Введите целое ЧИСЛО!!!");
// }

// if (number1 > number2)
//     Console.WriteLine($"Минимальное число {number2}, а максимальное {number1}.");
//     if (number1 < number2)
//         Console.WriteLine($"Минимальное число {number1}, а максимальное {number2}.");
//     else 
//         Console.WriteLine($"Э-э-э, слушай, не хитри!!! Число {number1} равно числу {number2}.");

//--------------------------------------------------------------------

// Задача №4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// int number1;
// Console.Write("Введите первое число: ");
// while (!int.TryParse(Console.ReadLine(), out number1))
// {
//     Console.WriteLine("Ошибка ввода! Введите целое ЧИСЛО!!!");
// }

// int number2;
// Console.Write("Введите второе число: ");
// while (!int.TryParse(Console.ReadLine(), out number2))
// {
//     Console.WriteLine("Ошибка ввода! Введите целое ЧИСЛО!!!");
// }

// int number3;
// Console.Write("Введите первое число: ");
// while (!int.TryParse(Console.ReadLine(), out number3))
// {
//     Console.WriteLine("Ошибка ввода! Введите целое ЧИСЛО!!!");
// }
// int max = number1;
// if(max < number2)
//     max = number2;
//     if (max < number3)
//     max = number3;

// Console.WriteLine($"Максимальное число: {max}.");

//--------------------------------------------------------------------

// Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// int number;
// Console.Write("Давай проверим число на четность и нечетность, вводи его сюда: ");
// while (!int.TryParse(Console.ReadLine(), out number))
// {
//     Console.WriteLine("Ошибка ввода! Введите целое ЧИСЛО!!!");
// }

// if (number1 % 2 == 0)
//     Console.WriteLine("Молодец, это число четное.");
//     else
//     Console.WriteLine("Нет, дружище, это число нечетное.");

//--------------------------------------------------------------------

// Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе 
// показывает все чётные числа от 1 до N.

// int number;
// Console.Write("А теперь выведем все четные числа от этого числа: ");
// while (!int.TryParse(Console.ReadLine(), out number))
// {
//     Console.WriteLine("Ошибка ввода! Введите целое ЧИСЛО!!!");
// }
// int current = 2;

// while (current <= number) {
//     if(current % 2 == 0)
//     Console.Write(current + " ");
//     else 
//     continue;
//     current +=2;
// }
