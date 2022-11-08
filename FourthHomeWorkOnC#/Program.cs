// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// int PowOfNumber(int a, int b) 
// {
//     int temp = a;
//     Console.Write(a + " ");
//     for(int i = 1; i < b; i++) {
//         a = a * temp;
//         Console.Write(a + " ");
//     }
//     Console.WriteLine();
//     return a;

// }
// Console.Write("Please input the number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please input the pow: ");
// int pow = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"The reasult is: {PowOfNumber(num, pow)}");
// Console.WriteLine("Check with Math.Pow: " + Math.Pow(num,pow));


// ---------------------------------------------------------------------------------


// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int SumOfDigits(int number) 
// {
//     int digitSum = 0;
//     while (number != 0) 
//     {
//         digitSum = digitSum + (number % 10);
//         number /= 10;
//     }
//     return digitSum;
// }

// Console.Write("Input number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Sum of digits is {SumOfDigits(n)}");



// ---------------------------------------------------------------------------------


// Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

// int[] CreateUsersArray(int size) 
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++) 
//     {
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }


// void ShowArray(int[] array) 
// {
//     for(int i = 0; i < array.Length; i++) 
//         Console.Write(array[i] + " ");
// }

// Console.Write("Input size: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] arr = CreateUsersArray(n);
// ShowArray(arr);