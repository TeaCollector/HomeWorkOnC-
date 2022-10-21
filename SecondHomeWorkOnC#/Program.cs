// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

// int SecDigit(int num) 
// {
//     int twoDigits = num / 10;
//     int thirfDigit = twoDigits % 10; 
//     return thirfDigit;
// }
// Console.WriteLine("Давай я покажу тебе вторую цифру числа, которого ты введешь, вводи: ");

// int result = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"И вот она: {SecDigit(result)}.");


// ---------------------------------------------------------------------------


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// int thirdDigit(int num) 
// {
//     if (num < 100)
//         return 0;
//     while(num > 999) 
//     {
//         num /= 10;
//         if(num < 1000)
//             break;
//     }
//     num %= 10; 
//     return num;
// }
// Console.WriteLine("Ведите пожалуйста число и увидите его третью цифру: ");
// int result = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Третья цифра такая: {thirdDigit(result)}");



// ---------------------------------------------------------------------------



// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// string DayOfWeek(int day) 
// {
//     if (day <= 0 || day > 7)
//     return "Нет такого дня недели.";
//     if (day < 6) 
//         return "Работаем!";
//     else 
//         return "Отдыхаем!";
// }

// int day = Convert.ToInt32(Console.ReadLine());
// string answer = DayOfWeek(day);
// Console.WriteLine(answer);
