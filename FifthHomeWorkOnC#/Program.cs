int[] CreateRandomArray(int size, int minValue, int maxValue) 

{
    int[] array = new int[size];

    for(int i = 0; i < size; i++) 
    
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++) 
        Console.Write( + array[i] + " ");
    Console.WriteLine();
}

//----------------------------------------------------------------------------------------

// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int CountOfEvenNumber(int[] arr) 
// {
//     int counter = 0;
//     for(int i = 0; i < arr.Length; i++) 
//     {
//         if(arr[i] % 2 == 0) 
//             counter++;
//     }    
//     return counter;
// }

// Console.Write("Input size of array: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min three-digit random number: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max three-digit random number: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateRandomArray(n, min, max);
// ShowArray(array);
// Console.Write($"The sum of all even number in array is {CountOfEvenNumber(array)}");

// ------------------------------------------------------------------------------------

//  Задайте одномерный массив, заполненный случайными числами. 
//  Найдите сумму элементов, стоящих на нечётных позициях.

// int SumOfElement(int[] arr) 
// {
//     int sum = 0;
//     for(int i = 0; i < arr.Length; i++)
//     {
//         if(i % 2 == 1)
//             sum += arr[i];
//     }
//     return sum;
// }

// Console.Write("Input size of array: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min random number: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max random number: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateRandomArray(n, min, max);
// ShowArray(array);
// Console.Write($"The sum of all even-position is {SumOfElement(array)}");

//-------------------------------------------------------------------------------------------

// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.

double[] CreateRandomArrayRealNumber(int size, int min, int max) 
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++) 
    {
        array[i] = Math.Round(new Random().NextDouble(), 2) + new Random().Next(min,max);
     // array[i] = Math.Round(new Random().NextDouble() * 100, 2);
    }
    return array;
}

double difference(double[] arr) 
{
    double max = arr[0];
    double min = arr[0];
    for(int i = 0; i < arr.Length; i++) 
    {
        if(max < arr[i])
            max = arr[i];
        else if (min > arr[i])
            min = arr[i];
    }
    return max - min;
}
Console.Write("Input size of array: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max namber: ");
int max = Convert.ToInt32(Console.ReadLine());
double[] arr = CreateRandomArrayRealNumber(n, min, max);
ShowArray(arr);
double result = Math.Round(difference(arr), 2);
Console.Write($"Differernce of max and min value in array is {result}");