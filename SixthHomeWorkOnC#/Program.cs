//  Пользователь вводит с клавиатуры M чисел. 
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int AboveZero(int number)
// {
//     int counter = 0;
//     int i = 1;
    
//     while(number > 0) 
//     {
//         Console.Write($"Input {i} number: ");
//         int inPutNum = Convert.ToInt32(Console.ReadLine());
//         if(inPutNum > 0) 
//             counter++;
//         i += 1;
//         number -= 1;
//     }
//     return counter;
// }
// Console.Write("Input amount of number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Amount of number above zero is {AboveZero(number)}. ");


// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// 1. Прямые могут быть одной и той же линией.
// 2. Быть параллельнимы.
// 3. И пересекаться.

string PointOfIntersection(double b1, double k1, double b2, double k2)
{
    if(k1 == k2) 
    {
        if(b1 == b2) 
            return "You input coordination of the same line's.";
        return "You input coordination of the parallel line's.";
    }
    double x = (b2 - b1)/(k1 - k2);
    double y = k1*x + b1;
    return $"Point of intersection of your two lines is ({x},{y})";
}
Console.Write("Input coordination of the line, enter the b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write(PointOfIntersection(b1, k1, b2, k2));