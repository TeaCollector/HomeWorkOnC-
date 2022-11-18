// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


double [,] Createarray2D (int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double [rows, columns];
    for(int i = 0; i < rows; i++) 
        for(int j = 0; j < columns; j++) 
        {
            int integer = new Random().Next(minValue,maxValue + 1);        
            array[i,j] = integer + Math.Round(new Random().NextDouble(), 2);
        }
    return array;
}

void show2DDoubleArray (double[,] array) 
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input number of rows: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of max possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of minimun possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[,] array = Createarray2D(n, m, minValue ,maxValue);

show2DDoubleArray(array);




//-----------------------------------------------------------------------------------------





// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// void show2Darray (int[,] array) 
// {
//     for(int i = 0; i < array.GetLength(0); i++) 
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int [,] Createarray2D (int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int [rows, columns];
//     for(int i = 0; i < rows; i++) 
//         for(int j = 0; j < columns; j++) 
//             array[i,j] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }

// bool PositionOfNumber(int[,] array, int rowsPosition, int columnsPosition) 
// {
//     if (rowsPosition < array.GetLength(0) && columnsPosition < array.GetLength(1)) return true; 
//     else return false;
// }

// string PositionOfNumber(int[,] array, int rowsPosition, int columnsPosition) 
// {
//     if (rowsPosition < array.GetLength(0) && columnsPosition < array.GetLength(1)) 
//     {
//         return $"Number of your position is {array[rowsPosition,columnsPosition]}."; 
//     }
//         else 
//             return "The number is absence.";
// }


// Console.Write("Input number of rows: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of columns: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of max possible value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of minimun possible value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[,] array = Createarray2D(n, m, minValue, maxValue);
// show2Darray(array);

// Console.Write("Input index of rows position: ");
// int rowsPosition = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input index of column position: ");
// int columnsPosition = Convert.ToInt32(Console.ReadLine());

// bool numberIsPresent = PositionOfNumber(array, rowsPosition, columnsPosition);
// Console.Write($"The number is present? {numberIsPresent}.");

// string number = PositionOfNumber(array, rowsPosition, columnsPosition);
// Console.Write(number);




//-------------------------------------------------------------------------------------




// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// double[] AverageNumber(int[,] array) 
// {
//     double[] average = new double[array.GetLength(1)];
//     int j = 0;
//     for(int i = 0; i < array.GetLength(0); i++) 
//     {
//         double sum = 0;
//         for(j  = 0; j < array.GetLength(1); j++)       
//             sum += array[j,i];      
//         average[i] = Math.Round(sum, 2) / j;
//     }
//     return average;
// }
// void ShowDoubleArray (double[] array) 
// {
//     for(int i = 0; i < array.Length; i++) 
//         Console.Write(array[i] + " ");
// }


// Console.Write("Input number of rows: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of columns: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of max possible value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of minimun possible value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[,] array = Createarray2D(n, m, minValue, maxValue);
// show2Darray(array);
// double[] doubleArray = AverageNumber(array);
// ShowDoubleArray(doubleArray);
