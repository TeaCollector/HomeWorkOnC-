// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
 
//  int [,] Createarray2D (int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int [rows, columns];
//     for(int i = 0; i < rows; i++) 
//         for(int j = 0; j < columns; j++) 
//             array[i,j] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }

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

// void Descending2DArray(int[,] array) 
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 1; j < array.GetLength(1); j++)
//         {
//             int maxValue = array[i, j];
//             int k = j;
//                 while(k > 0 && array[i, k - 1] < maxValue)
//                 {
//                     array[i, k] = array[i, k - 1];
//                     --k;
//                 }
//                 array[i, k] = maxValue;
            
//         }
//     }
       
// }



// Console.Write("Input number of rows: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of columns: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of min possible value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of max possible value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[,] array = Createarray2D(n, m, minValue, maxValue);
// show2Darray(array);
// Descending2DArray(array);
// show2Darray(array);





// ----------------------------------------------------------------------------------------





// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// string FindRow(int[,] array) 
// {
//     int[] arrayWithMinNumber = new int[array.GetLength(0)];

//     int row = 0;
//     int minSum = 0;
    
//     for(int i = 0; i < array.GetLength(0); i ++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             minSum = minSum + array[i, j];
        
//         arrayWithMinNumber[i] = minSum;
//         minSum = 0;
//     }

//     row = findMinIndex(arrayWithMinNumber);
//     return $"Number of row with sum of minimal elements is: {row + 1}.";
// }
// int findMinIndex(int[] array) 
// {
//     int index = 0;
//     for(int i = 0; i < array.Length - 1; i++)
//     {
//         if(array[i] < array[i + 1])
//             index = i;
//     }
//     return index;
// }

// Console.WriteLine(FindRow(array));





// ----------------------------------------------------------------------------------------





// Задайте две матрицы. Напишите программу,                             2 4 | 3 4    ->  18 20
// которая будет находить произведение двух матриц.                     3 2 | 3 3    ->  15 18

// int[,] MultiplicationOfTwoMatrix(int[,] array1, int[,] array2)
// {
//     int[,] resultArray = new int[array2.GetLength(0), array2.GetLength(1)];

//     if(array1.GetLength(1) != array2.GetLength(0)) return resultArray; 

//     for (int i = 0; i < array1.GetLength(0); i++)
//             {
//                 for (int j = 0; j < array2.GetLength(1); j++)
//                 {
//                     for (int k = 0; k < array2.GetLength(0); k++)
//                     {
//                         resultArray[i,j] += array1[i,k] * array2[k,j];
//                     }
//                 }
//             }
//     return resultArray;
//  }

// Console.Write("Input number of rows first array: ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of columns first array: ");
// int m1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min possible number value of first array: ");
// int minValue1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max possible number value of the first array: ");
// int maxValue1 = Convert.ToInt32(Console.ReadLine());
// int[,] array1 = Createarray2D(n1, m1, minValue1, maxValue1);

// Console.Write("Input number of rows second array: ");
// int n2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of columns second array: ");
// int m2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min possible number value of second array: ");
// int minValue2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max possible number value of the second array: ");
// int maxValue2 = Convert.ToInt32(Console.ReadLine());

// int[,] array2 = Createarray2D(n2, m2, minValue2, maxValue2);
// Console.WriteLine();
// Console.WriteLine("This is first array: ");
// show2Darray(array1);
// Console.WriteLine("This is second array below: ");
// show2Darray(array2);
// Console.WriteLine("And this is the result: ");
// show2Darray(MultiplicationOfTwoMatrix(array1, array2));
   





// ----------------------------------------------------------------------------------------









// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.


int[,,] TrippleArray(int rows, int columns, int deep, int minValue, int maxValue)
{
    int[,,] trippleArray = new int[rows, columns, deep];
    int l = 0;
    int[] arrayForUniqElements = CreateUniqNumber(new int[rows*columns*deep], minValue, maxValue + 1);
    if(rows * columns * deep > 89) return null;

    for(int i = 0; i < trippleArray.GetLength(0); i++)
    {
        for(int j = 0; j < trippleArray.GetLength(1); j++)
        {
            for(int k = 0; k < trippleArray.GetLength(2); k++) 
            {              
                trippleArray[i, j, k] = arrayForUniqElements[l++];
            }
        }
    }
    return trippleArray;
}


void Show3DArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        Console.WriteLine("On the page number " + i);
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                
               Console.Write("Number: " + array[i, j, k]+ " position: " + "(" + j + "," + k + ")    " );
                // Console.Write(array[i, j, k] + " ");
            }
            Console.WriteLine();
        }
    }
}


Console.Write("Input number of rows: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of deep: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[,,] array = TrippleArray(n, m,r, minValue, maxValue);
Show3DArray(array);




int[] CreateUniqNumber(int[] array, int minValue, int maxValue)
{
    int[] newArr = new int[array.Length];
    int j = 0;
    while (j < newArr.Length) 
   {
    int number = new Random().Next(minValue, maxValue + 1);

    for(int i = 0; i < newArr.Length; i++) 
    {
        if(number != newArr[i])
            continue;
        else 
        {
            number = new Random().Next(minValue, maxValue + 1);
            i = 0;
        }    
    }
    newArr[j++] = number;
   }
    return newArr;
}

// тестовый метод для массива:

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++) 
//         Console.Write( + array[i] + " ");
//     Console.WriteLine();
// }

// int[] ar = CreateUniqNumber(new int [20], 0, 19);

// ShowArray(ar);



// ----------------------------------------------------------------------------------------


// Не решена, к сожалению, не смог сформулировать правильные условия.



// Напишите программу, которая заполнит спирально массив 4 на 4.
// 01 02 03 04                  01 02 03 04 05 06 07
// 12 13 14 05                  16 17 18 19 20 21 08
// 11 16 15 06                  15 14 13 12 11 10 09
// 10 09 08 07
 
//  int[,] SpiralArray(int[,] array)
//  {
//     int k = 1;
//     int i = 0;
//     int j = 0;
//     while(j != array.GetLength(0) * array.GetLength(1))
//     {
//         array[i, j++] = k++;
//         if(j == array.GetLength(1) - 1) 
//         {
//             while(i < array.GetLength(0) - 1) 
//             {
//                 array[i++, j] = k++;
//             }
//             else if (j == 0) 
//             {
//                 array[]                
//             }
//         }
        

//     }   
//     return array;
// }

// Console.Write("Input number of rows: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of columns: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] array = SpiralArray(new int[n, m]);
// show2Darray(array);

 
