//  Задайте значение N. Напишите программу, которая выведет все натуральные числа
//  в промежутке от N до 1. Выполнить с помощью рекурсии.

// void ShowNumbers(int n) 
// {
//     if(n == 0) return;
//     Console.Write(n + ", ");
//     if(n != 1) ShowNumbers(n - 1);
// }
// Console.Write("Please input integer to show sequence: ");
// int n = Convert.ToInt32(Console.ReadLine());
// ShowNumbers(n);

// ----------------------------------------------------------------------------------------


// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// int Fibonacci(int m, int n) 
// {
//     if(m <= n) 
//         return Fibonacci(m + 1, n) + m;
//     return 0;
// }
// Console.Write("Please input first integer: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please input second integer: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write(Fibonacci(m,n));


// ----------------------------------------------------------------------------------------


// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int Accerman(int n, int m) 
{
    if (n == 0) return m + 1;
        if (n != 0 && m == 0) 
            return Accerman(n - 1, 1);
        if (n > 0 && m > 0) return Accerman(n - 1, Accerman(n, m - 1));
            return Accerman(n,m);
}

Console.Write("Please input first integer: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input second integer: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write(Accerman(n,m));